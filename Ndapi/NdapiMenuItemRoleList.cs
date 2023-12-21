using System.Collections;
using System.Collections.Generic;

namespace Ndapi
{
    public class NdapiMenuItemRoleList : IEnumerable<string>
    {
        private readonly MenuItem _menuItem;
        private readonly int _count;

        internal NdapiMenuItemRoleList(MenuItem menuitem)
        {
            _menuItem = menuitem;
            _count = menuitem.GetNumberProperty(NdapiConstants.D2FP_OBJ_COUNT);
        }

        public int Count => _count;

        public IEnumerator<string> GetEnumerator() => new Enumerator(this);

        IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

        public sealed class Enumerator : IEnumerator<string>
        {
            private readonly NdapiMenuItemRoleList _ndapiMenuItemRoleList;
            private int _position;
            private string _current;

            internal Enumerator(NdapiMenuItemRoleList ndapiMenuItemRoleList)
            {
                _ndapiMenuItemRoleList = ndapiMenuItemRoleList;
                _position = 1;
            }

            public bool MoveNext()
            {
                if (_position > _ndapiMenuItemRoleList.Count)
                {
                    return false;
                }

                _current = _ndapiMenuItemRoleList._menuItem.GetRoleAt(_position);
                _position++;
                return true;
            }

            public void Reset() => _position = 1;

            public string Current => _current;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
    }
}
