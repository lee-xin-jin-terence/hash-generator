using HashGeneratorApp.Models;
using System;
using System.Web.UI;

namespace HashGeneratorApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Upon the user selecting a different hash algorithm, update the text on
        ///     the generate hash button. Also, pudate the hashOutput textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void hashAlgorithmDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.generateHashButton.Text = "Generate " + this.hashAlgorithmDropDownList.SelectedItem.Value +
                                    " Hash";

            this.hashOutputTextBox.Text = "";
        }


        /// <summary>
        /// Event handler fot the generateHashButton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void generateHashButton_Click(object sender, EventArgs e)
        {
            this.GenerateHash();
        }



        /// <summary>
        /// Generate a hash from the user input entered and the hash algorithm selected,
        /// and display it in the output text box
        /// </summary>
        private void GenerateHash() 
        {
            HashGenerator.HashAlgorithmType userSelectedHashType = GetHashAlgorithmType();

            string userHashInput = this.hashInputTextBox.Text;

            string hashOutputString = HashGenerator.GenerateHash(userHashInput, userSelectedHashType);

            this.hashOutputTextBox.Text = hashOutputString;
        }



        /// <summary>
        /// Returns the hash algorithm type based on what the user has selected from
        ///         the drop-down list. Helper method for the GenerateHash() method
        /// </summary>
        /// <returns></returns>
        private HashGenerator.HashAlgorithmType GetHashAlgorithmType()
        {
            HashGenerator.HashAlgorithmType hashType = HashGenerator.HashAlgorithmType.MD5;

            switch (this.hashAlgorithmDropDownList.SelectedItem.Value)
            {
                case "MD5":
                    hashType = HashGenerator.HashAlgorithmType.MD5;
                    break;

                case "SHA1":
                    hashType = HashGenerator.HashAlgorithmType.SHA1;
                    break;

                case "SHA256":
                    hashType = HashGenerator.HashAlgorithmType.SHA256;
                    break;


                case "SHA384":
                    hashType = HashGenerator.HashAlgorithmType.SHA384;
                    break;


                case "SHA512":
                    hashType = HashGenerator.HashAlgorithmType.SHA512;
                    break;

            }


            return hashType;

        }


        


        
    }
}