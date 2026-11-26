using System;
using System.Collections;
using System.Collections.Generic;

using Ndapi.Core;
using Ndapi.Enums;
using Ndapi.Metadata;

namespace Ndapi;

public class NdapiObjectList<T> : IEnumerable<T> where T : NdapiObject
{
    private readonly NdapiObject _ndapiObject;
    private readonly NdapiConstant _property;

    public T this[int index]
    {
        get
        {
            ArgumentOutOfRangeException.ThrowIfNegative(index);
            var position = 0;
            foreach (var item in this)
            {
                if (position++ == index)
                {
                    return item;
                }
            }

            throw new ArgumentOutOfRangeException(nameof(index));
        }
    }

    internal NdapiObjectList(NdapiObject ndapiObject, NdapiConstant property)
    {
        _ndapiObject = ndapiObject;
        _property = property;
    }

    public IEnumerator<T> GetEnumerator() => new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    public void RemoveAll()
    {
        // the next object is read before destroying the current one, which frees it
        var current = _ndapiObject.GetObjectProperty<T>(_property);
        while (current is not null)
        {
            var next = current.GetNext<T>();
            current.Destroy();
            current = next;
        }
    }

    /// <summary>
    /// Finds an object by name.
    /// </summary>
    /// <param name="name">Name of the object.</param>
    /// <returns>The object that was found. Returns null if the object doesn't exist.</returns>
    public T? Single(string name)
    {
        var type = NdapiMetadata.GetObjectTypeFrom<T>();
        var internalObjectType = ConstantConverter.GetValue(type);

        var status = NativeMethods.d2fobfo_FindObj(NdapiContext.GetContext(), _ndapiObject.Handle, name, internalObjectType, out var handle);
        if (status == FormsErrorCode.ObjectNotFound)
        {
            return null;
        }
        Ensure.Success(status);

        return NdapiObject.Create<T>(handle);
    }

    public sealed class Enumerator : IEnumerator<T>
    {
        private readonly NdapiObjectList<T> _objectList;
        private T? _current;
        private bool _started;

        internal Enumerator(NdapiObjectList<T> ndapiObjectList)
        {
            _objectList = ndapiObjectList;
        }

        public bool MoveNext()
        {
            if (!_started)
            {
                _started = true;
                _current = _objectList._ndapiObject.GetObjectProperty<T>(_objectList._property);
            }
            else if (_current is not null)
            {
                _current = _current.GetNext<T>();
            }

            return _current is not null;
        }

        public void Reset()
        {
            _current = null;
            _started = false;
        }

        public T Current =>
            _current ?? throw new InvalidOperationException("The enumeration has not started or has already finished.");

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
