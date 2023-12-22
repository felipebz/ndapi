using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiObjectLibraryTabObjectsList : IEnumerable<NdapiObject>
    {
        private readonly ObjectLibraryTab _objectLibraryTab;

        public NdapiObject this[int index] => _objectLibraryTab.GetObjectByPosition(index);

        internal NdapiObjectLibraryTabObjectsList(ObjectLibraryTab objectLibraryTab)
        {
            _objectLibraryTab = objectLibraryTab;
            Count = _objectLibraryTab.GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);
        }

        public int Count { get; }

        public bool Any() => Count > 1;

        public IEnumerator<NdapiObject> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public sealed class Enumerator : IEnumerator<NdapiObject>
        {
            private readonly NdapiObjectLibraryTabObjectsList _list;
            private int _position;

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

                Current = _list._objectLibraryTab.GetObjectByPosition(_position);
                _position++;
                return true;
            }

            public void Reset() => _position = 1;

            public NdapiObject Current { get; private set; }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
