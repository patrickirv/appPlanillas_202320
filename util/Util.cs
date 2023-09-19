using System.Windows.Forms;

namespace appPlanillas_202320.util
{
  internal class Util
  {
    internal bool LetterSpaceBack(object sender, KeyPressEventArgs e)
    {
      string txt = ((TextBox)sender).Text;
      char tecla = e.KeyChar;
      bool isLetter = char.IsLetter(tecla);
      bool isWhiteSpace = char.IsWhiteSpace(tecla);
      bool isBackSpace = tecla == (char)Keys.Back;

      if ( !isLetter &&
           !isWhiteSpace &&
           !isBackSpace ||
           ( isWhiteSpace && txt == "" ) ||
           ( isWhiteSpace && txt.EndsWith( " " ) ) )
        return true;

      return false;
    }
  }
}
