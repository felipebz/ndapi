using System;
using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiObjectList<T> : IEnumerable<T> where T : BaseNdapiObject
    {
        private readonly BaseNdapiObject _ndapiObject;
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

        internal NdapiObjectList(BaseNdapiObject ndapiObject, int property)
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
                } else
                {
                    _current = _current.GetObjectProperty<T>(NdapiConstants.D2FP_NEXT);
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
