﻿using System.Windows.Forms;

namespace NTCSAttendanceStaffClient
{
    public static class SqlErrorDialog
    {
        /// <summary>
        /// Shows a message which says that the connection to the SQL Server failed.
        /// </summary>
        public static void ShowRuntimeConnectionErrorMessage()
        {
            MessageBox.Show("The connection to the SQL Server failed.\r\n\r\nIf your password was changed, close and reopen the program to log in again using your new password.\r\nOtherwise, make sure that you are connected to a network, and try refreshing this window.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a message which says that the connection to the SQL Server failed, along with the specific error message.
        /// </summary>
        /// <param name="errorMessage">The SQL error message to show.</param>
        public static void ShowRuntimeConnectionErrorMessage(string errorMessage)
        {
            MessageBox.Show($"The connection to the SQL Server failed.\r\nThe error was as follows:\r\n{errorMessage}\r\n\r\nIf your password was changed, close and reopen the program to log in again using your new password.\r\nOtherwise, make sure that you are connected to a network, and try refreshing this window.", "Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
