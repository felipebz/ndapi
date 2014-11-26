using Ndapi;
using Ndapi.Enums;
using System;

namespace CreateModuleDemo
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            /*
            This example creates a master-detail form based on the dept and emp database tables owned by the user scott.
            The master contains the following fields: empno, ename, job, sal, and deptno.
            The detail contains the following fields deptno, dname, and loc.
            The join condition is deptno.
            */

            // Create the form
            var module = new FormModule("empdept");

            // Create a window
            var mywin = new Window(module, "MYWIN");

            // Create a canvas and set canvas-related properties
            var mycanvas = new Canvas(module, "MYCANVAS")
            {
                ViewportWidth = 512,
                ViewportHeight = 403,
                ViewportXPosition = 0,
                ViewportYPosition = 0,
                Width = 538,
                Height = 403,
                Window = mywin,
            };

            // Create Emp block and set block-related properties
            var emp = new Block(module, "EMP")
            {
                DatabaseBlock = true,
                QueryDataSourceType = QueryDataSourceType.Table,
                QueryDataSourceName = "EMP",
                DMLDataTargetType = DMLDataTargetType.Table,
                DMLDataTargetName = "EMP"
            };

            // Create Dept block and set block-related properties
            var dept = new Block(module, "DEPT")
            {
                DatabaseBlock = true,
                QueryDataSourceType = QueryDataSourceType.Table,
                QueryDataSourceName = "DEPT",
                DMLDataTargetType = DMLDataTargetType.Table,
                DMLDataTargetName = "DEPT"
            };

            // Create empno item and item-related properties
            var empno = new Item(emp, "EMPNO")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Number,
                MaximumLength = 6,
                Required = true,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 6,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 32,
                YPosition = 50,
                Width = 51,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :EMPNO"
            };

            // Create Ename item and item-related properties
            var ename = new Item(emp, "ENAME")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Char,
                MaximumLength = 10,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 10,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 83,
                YPosition = 50,
                Width = 77,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :ENAME"
            };

            // Create JOB item and item-related properties
            var job = new Item(emp, "JOB")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Char,
                MaximumLength = 9,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 9,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 160,
                YPosition = 50,
                Width = 70,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :JOB"
            };

            // Create SALARY item and item-related properties
            var sal = new Item(emp, "SAL")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Number,
                MaximumLength = 9,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 9,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 352,
                YPosition = 50,
                Width = 70,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :SAL"
            };

            // Create DEPTNO item and item-related properties
            var deptnoEmp = new Item(emp, "DEPTNO")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Number,
                MaximumLength = 4,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 4,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 493,
                YPosition = 50,
                Width = 30,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :DEPTNO"
            };

            // Create DEPTNO item and item-related properties
            var deptnoDept = new Item(dept, "DEPTNO")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Number,
                MaximumLength = 4,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 4,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 32,
                YPosition = 151,
                Width = 38,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :DEPTNO"
            };

            // Create DNAME item and item-related properties
            var dname = new Item(dept, "DNAME")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Char,
                MaximumLength = 14,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 14,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 70,
                YPosition = 151,
                Width = 102,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :DNAME"
            };

            // Create LOC item and item-related properties
            var loc = new Item(dept, "LOC")
            {
                ItemType = ItemType.TextItem,
                Enabled = true,
                KeyboardNavigable = true,
                DataType = ItemDataType.Char,
                MaximumLength = 13,
                DistanceBetweenRecords = 0,
                DatabaseItem = true,
                QueryAllowed = true,
                QueryLength = 14,
                UpdateAllowed = true,
                Visible = true,
                Canvas = mycanvas,
                XPosition = 173,
                YPosition = 151,
                Width = 96,
                Height = 17,
                Bevel = Bevel.Lowered,
                Hint = "Enter value for :LOC"
            };

            // Create Relations and relations-related properties
            var relation = new BlockRelation(dept, "DEPT_EMP")
            {
                DetailBlock = "EMP",
                DeleteRecordBehavior = DeleteRecordBehavior.NonIsolated,
                Deferred = false,
                AutomaticQuery = false,
                PreventMasterlessOperations = false,
                JoinCondition = "DEPTNO"
            };
            relation.Generate();

            module.Save();
        }
    }
}
