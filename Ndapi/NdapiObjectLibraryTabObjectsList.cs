using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiObjectLibraryTabObjectsList : IEnumerable<NdapiObject>
    {
        private readonly ObjectLibraryTab _objectLibraryTab;
        private readonly int _count;

        public NdapiObject this[int index] => _objectLibraryTab.GetObjectByPosition(index);

        internal NdapiObjectLibraryTabObjectsList(ObjectLibraryTab objectLibraryTab)
        {
            _objectLibraryTab = objectLibraryTab;
            _count = _objectLibraryTab.GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);
        }

        public int Count => _count;

        public bool Any() => _count > 1;

        public IEnumerator<NdapiObject> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public sealed class Enumerator : IEnumerator<NdapiObject>
        {
            private readonly NdapiObjectLibraryTabObjectsList _list;
            private int _position;
            private NdapiObject _current;

            internal Enumerator(NdapiObjectLibraryTabObjectsList list)
            {
                _list = list;
                _position = 1;
            }

            public bool MoveNext()
            {
                if (_position > _list.Count)
                {
                    return false;
                }

                _current = _list._objectLibraryTab.GetObjectByPosition(_position);
                _position++;
                return true;
            }

            public void Reset() => _position = 1;

            public NdapiObject Current => _current;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
