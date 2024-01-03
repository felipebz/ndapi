using System.Collections;
using System.Collections.Generic;

using Ndapi.Core;

namespace Ndapi;

public class NdapiMenuItemRoleList : IEnumerable<string>
{
    private readonly MenuItem _menuItem;

    internal NdapiMenuItemRoleList(MenuItem menuitem)
    {
        _menuItem = menuitem;
        Count = menuitem.GetNumberProperty(NdapiConstant.D2FP_OBJ_COUNT);
    }

    public int Count { get; }

    public IEnumerator<string> GetEnumerator() => new Enumerator(this);

    IEnumerator IEnumerable.GetEnumerator() => new Enumerator(this);

    public sealed class Enumerator : IEnumerator<string>
    {
        private readonly NdapiMenuItemRoleList _ndapiMenuItemRoleList;
        private int _position;

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

            Current = _ndapiMenuItemRoleList._menuItem.GetRoleAt(_position);
            _position++;
            return true;
        }

        public void Reset() => _position = 1;

        public string Current { get; private set; }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }
    }
}
