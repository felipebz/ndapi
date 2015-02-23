using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;
using Ndapi.Metadata;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiObjectList<T> : IEnumerable<T> where T : NdapiObject
    {
        private readonly NdapiObject _ndapiObject;
        private readonly int _property;

        public T this[int index]
        {
            get
            {
                var enumerator = GetEnumerator();
                for (var i = 0; i <= index; i++)
                {
                    if (!enumerator.MoveNext())
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }
                }

                return enumerator.Current;
            }
        }

        internal NdapiObjectList(NdapiObject ndapiObject, int property)
        {
            _ndapiObject = ndapiObject;
            _property = property;
        }

        public IEnumerator<T> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public void RemoveAll()
        {
            var enumerator = GetEnumerator();

            var value = enumerator.Current;
            while (value != null)
            {
                enumerator.MoveNext();
                var nextValue = enumerator.Current;
                value.Destroy();
                value = nextValue;
            }
        }

        /// <summary>
        /// Finds an object by name.
        /// </summary>
        /// <param name="name">Name of the object.</param>
        /// <returns>The object that was found. Returns null if the object doesn't exist.</returns>
        public T Single(string name)
        {
            var type = NdapiMetadata.GetObjectTypeFrom<T>();
            ObjectSafeHandle handle;

            var status = NativeMethods.d2fobfo_FindObj(NdapiContext.Context, _ndapiObject._handle, name, type, out handle);
            if (status == D2fErrorCode.D2FS_OBJNOTFOUND)
            {
                return null;
            }
            Ensure.Success(status);

            return NdapiObject.Create<T>(handle);
        }

        public sealed class Enumerator : IEnumerator<T>
        {
            private readonly NdapiObjectList<T> _objectList;
            private T _current;

            internal Enumerator(NdapiObjectList<T> ndapiObjectList)
            {
                _objectList = ndapiObjectList;
            }

            public bool MoveNext()
            {
                if (_current == null)
                {
                    _current = _objectList._ndapiObject.GetObjectProperty<T>(_objectList._property);
                }
                else
                {
                    _current = _current.GetNext<T>();
                }

                return _current != null;
            }

            public void Reset() => _current = null;

            public T Current
            {
                get
                {
                    if (_current == null)
                    {
                        MoveNext();
                    }

                    return _current;
                }
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
