using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_ConectorBD
{
    internal partial class csCuadroDialogo
    {

        internal static String CuadroDialogo(string sTitulo, string sEtiqueta, string sValor)
        {
            Form frmCuadroDialogo = new Form();
            Label lblTitulo = new Label();
            TextBox txtInput = new TextBox();
            Button btnOk = new Button();
            Button btnCancel = new Button();

            frmCuadroDialogo.Text = sTitulo;
            lblTitulo.Text = sEtiqueta;
            txtInput.Text = sValor;
            txtInput.PasswordChar = '*';

            btnOk.Text = "OK";
            btnCancel.Text = "Cancel";
            btnOk.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            lblTitulo.SetBounds(9, 20, 372, 13);
            txtInput.SetBounds(12, 36, 372, 20);
            btnOk.SetBounds(228, 72, 75, 23);
            btnCancel.SetBounds(309, 72, 75, 23);

            lblTitulo.AutoSize = true;
            txtInput.Anchor = txtInput.Anchor | AnchorStyles.Right;
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            frmCuadroDialogo.ClientSize = new Size(396, 107);
            frmCuadroDialogo.Controls.AddRange(new Control[] { lblTitulo, txtInput, btnOk, btnCancel });
            frmCuadroDialogo.ClientSize = new Size(Math.Max(300, lblTitulo.Right + 10), frmCuadroDialogo.ClientSize.Height);
            frmCuadroDialogo.FormBorderStyle = FormBorderStyle.FixedDialog;
            frmCuadroDialogo.StartPosition = FormStartPosition.CenterScreen;
            frmCuadroDialogo.MinimizeBox = false;
            frmCuadroDialogo.MaximizeBox = false;
            frmCuadroDialogo.AcceptButton = btnOk;
            frmCuadroDialogo.CancelButton = btnCancel;

            DialogResult dialogResult = frmCuadroDialogo.ShowDialog();
            sValor = txtInput.Text;
            return sValor;
        }
    }
}
