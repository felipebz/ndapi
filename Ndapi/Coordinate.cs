using Ndapi.Core;
using Ndapi.Core.Handles;
using Ndapi.Enums;

namespace Ndapi
{
    /// <summary>
    /// Represents a coordinate declaration.
    /// </summary>
    public class Coordinate : BaseNdapiObject
    {
        /// <summary>
        /// Creates a coordinate declaration
        /// </summary>
        public Coordinate() : base(ObjectType.Coordinate)
        {
            _handle = new ObjectSafeHandle();
            var status = NativeMethods.d2fcrdcr_Create(NdapiContext.Context, out _handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Extracts the coordinate declaration from a form module
        /// </summary>
        /// <param name="module">Form module.</param>
        public Coordinate(FormModule module) : this()
        {
            Extract(module);
        }

        internal Coordinate(ObjectSafeHandle handle) : base(handle)
        {
        }

        /// <summary>
        /// Gets or sets the height of the character cell.
        /// </summary>
        [Property(NdapiConstants.D2FP_CHAR_CELL_HGT)]
        public int CharacterCellHeight
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CHAR_CELL_HGT); }
            set { SetNumberProperty(NdapiConstants.D2FP_CHAR_CELL_HGT, value); }
        }

        /// <summary>
        /// Gets or sets the width of the character cell.
        /// </summary>
        [Property(NdapiConstants.D2FP_CHAR_CELL_WID)]
        public int CharacterCellWidth
        {
            get { return GetNumberProperty(NdapiConstants.D2FP_CHAR_CELL_WID); }
            set { SetNumberProperty(NdapiConstants.D2FP_CHAR_CELL_WID, value); }
        }

        /// <summary>
        /// Gets or sets the coordinate system.
        /// </summary>
        [Property(NdapiConstants.D2FP_COORD_SYS)]
        public CoordinateSystem CoordinateSystem
        {
            get { return GetNumberProperty<CoordinateSystem>(NdapiConstants.D2FP_COORD_SYS); }
            set { SetNumberProperty(NdapiConstants.D2FP_COORD_SYS, value); }
        }

        /// <summary>
        /// Gets or sets whether runtime should use the default font scaling method.
        /// </summary>
        [Property(NdapiConstants.D2FP_DFLT_FNT_SCALING)]
        public bool IsDefaultFontScaling
        {
            get { return GetBooleanProperty(NdapiConstants.D2FP_DFLT_FNT_SCALING); }
            set { SetBooleanProperty(NdapiConstants.D2FP_DFLT_FNT_SCALING, value); }
        }

        /// <summary>
        /// Gets or sets the real unit.
        /// </summary>
        [Property(NdapiConstants.D2FP_REAL_UNIT)]
        public RealUnit RealUnit
        {
            get { return GetNumberProperty<RealUnit>(NdapiConstants.D2FP_REAL_UNIT); }
            set { SetNumberProperty(NdapiConstants.D2FP_REAL_UNIT, value); }
        }

        /// <summary>
        /// Extract the coordinate declaration from the specified form module.
        /// </summary>
        /// <param name="module">Form module.</param>
        public void Extract(FormModule module)
        {
            var status = NativeMethods.d2fcrdex_Extract(NdapiContext.Context, _handle, module._handle);
            Ensure.Success(status);
        }

        /// <summary>
        /// Apply the coordinate declaration to the specified form module.
        /// </summary>
        /// <param name="module">Form module to be changed.</param>
        public void Apply(FormModule module)
        {
            var status = NativeMethods.d2fcrdap_Apply(NdapiContext.Context, _handle, module._handle);
            Ensure.Success(status);
        }
    }
}
