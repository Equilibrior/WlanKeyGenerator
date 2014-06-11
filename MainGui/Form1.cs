using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainGui
{
    /// ============================================================================================================================
    public partial class MainGui : Form
    {
        #region Konstanten

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>Konstante für "Anzahl Zeichen" in den Settings</summary>
        private const string CharacterCountSection = "DefaultCharacterCount";

        #endregion Konstanten

        #region Konstruktoren

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Konstruktor
        /// </summary>
        public MainGui()
        {
            InitializeComponent();
            SetDefaults();
        }

        #endregion Konstruktoren

        #region Methoden

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Setzt die Anfangswerte für die Checkboxen und die Zeichenanzahl
        /// </summary>
        private void SetDefaults()
        {
            chkBigLetters.Checked = true;
            chkLittleLetters.Checked = true;
            chkNumbers.Checked = true;
            chkSpecialcharacters.Checked = false;

            txtCountCharacters.Text = ReadSettings(CharacterCountSection);
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Erzeugt den Key anhand der Einstellungen
        /// </summary>
        /// <returns>Der generierte Key</returns>
        private string GenerateKey()
        {
            Random random = new Random();
            string Key = "";
            string characters = "";

            if (chkLittleLetters.Checked)
                characters += "abcdefghijklmnopqrstuvwxyz";
            if (chkBigLetters.Checked)
                characters += "ABCDEFGHIJKLMOPQRSTUVWXYZ";
            if (chkNumbers.Checked)
                characters += "0123456789";
            if (chkSpecialcharacters.Checked)
                characters += "!§$%&/()=?";
            List<char> charList = characters.ToList();
            int characterCount = int.Parse(txtCountCharacters.Text);
            for (int count = 0; count < characterCount; count++)
            {
                Key += charList[random.Next(0, characters.Length)];
            }
            return Key;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// summary>
        /// Schreibt die übergebenen Werte in die Settings
        /// </summary>
        /// <param name="section">Section unter der der Wert gespeichert werden soll, Einzigartig</param>
        /// <param name="value">Wert der gespeichert werden soll</param>
        private static void WriteSettings(String section, String value)
        {
            if (section.Equals(CharacterCountSection))
            {
                Properties.Settings.Default.DefaultCharacterCount = value;
                Properties.Settings.Default.Save();
            }
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Liest den Wert aus der übergebenen Section
        /// </summary>
        /// <param name="section">Section die gelesen werden soll</param>
        /// <returns>Den der Wert der Section oder String.Empty</returns>
        private static String ReadSettings(String section)
        {
            if (section.Equals(CharacterCountSection))
                return Properties.Settings.Default.DefaultCharacterCount;
            return string.Empty;
        }

        #endregion Methoden

        #region Eventhandler

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Eventhandler: Erzeugt den Key
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnGenerateKey_Click(object sender, EventArgs e)
        {
            txtGeneratedKey.Text = GenerateKey();
            txtGeneratedKey.Enabled = true;
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Eventhandler: Kopiert den Inhalt des Keyfensters in die Zwischenablage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCopy_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(txtGeneratedKey.Text);
        }

        /// ------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Speichert beim Schließen des Programms die zuletzt eingegebene Zeichenanzahl in die Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainGui_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteSettings(CharacterCountSection, txtCountCharacters.Text);
        }

        #endregion Eventhandler

    }
}
