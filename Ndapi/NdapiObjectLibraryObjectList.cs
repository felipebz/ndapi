using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiObjectLibraryObjectList : IEnumerable<BaseNdapiObject>
    {
        private readonly ObjectLibrary _objectLibrary;
        private readonly int _count;

        public BaseNdapiObject this[int index] => _objectLibrary.GetObjectByPosition(index);

        internal NdapiObjectLibraryObjectList(ObjectLibrary objectLibrary)
        {
            _objectLibrary = objectLibrary;
            _count = _objectLibrary.GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);
        }

        public int Count => _count;

        public bool Any() => _count > 1;

        public IEnumerator<BaseNdapiObject> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public sealed class Enumerator : IEnumerator<BaseNdapiObject>
        {
            private readonly NdapiObjectLibraryObjectList _ndapiLibraryObjectList;
            private int _position;
            private BaseNdapiObject _current;

            internal Enumerator(NdapiObjectLibraryObjectList ndapiLibraryObjectList)
            {
                _ndapiLibraryObjectList = ndapiLibraryObjectList;
                _position = 1;
            }

            public bool MoveNext()
            {
                if (_position > _ndapiLibraryObjectList.Count)
                {
                    return false;
                }

                _current = _ndapiLibraryObjectList._objectLibrary.GetObjectByPosition(_position);
                _position++;
                return true;
            }

            public void Reset() => _position = 1;

            public BaseNdapiObject Current
            {
                get
                {
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
