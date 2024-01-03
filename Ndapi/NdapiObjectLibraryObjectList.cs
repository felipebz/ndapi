using System.Collections;
using System.Collections.Generic;

using Ndapi.Core;

namespace Ndapi;

public class NdapiObjectLibraryObjectList : IEnumerable<NdapiObject>
{
    private readonly ObjectLibrary _objectLibrary;

    public NdapiObject this[int index] => _objectLibrary.GetObjectByPosition(index);

    internal NdapiObjectLibraryObjectList(ObjectLibrary objectLibrary)
    {
        _objectLibrary = objectLibrary;
        Count = _objectLibrary.GetNumberProperty(NdapiConstant.D2FP_OBJ_COUNT);
    }

    public int Count { get; }

    public bool Any() => Count > 1;

    public IEnumerator<NdapiObject> GetEnumerator() => new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    public sealed class Enumerator : IEnumerator<NdapiObject>
    {
        private readonly NdapiObjectLibraryObjectList _ndapiLibraryObjectList;
        private int _position;

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

            Current = _ndapiLibraryObjectList._objectLibrary.GetObjectByPosition(_position);
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
