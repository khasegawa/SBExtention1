using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.SmallBasic.Library;

/// <summary>
/// 拡張入出力クラスです。
/// </summary>
[SmallBasicType]
public static class ExtIO
{

#if true
    public static Primitive Trainer()
    {
        var result = new Primitive();
        result[1] = "Trainer1";
        result[2] = "Trainer2";
        return result;

    }
#endif

    /// <summary>
    /// 入力ボックス
    /// </summary>
    /// <param name="prompt">プロンプト文字列</param>
    /// <param name="title">タイトル</param>
    /// <returns>入力された文字列</returns>
    public static Primitive InpBox(Primitive prompt, Primitive title)
    {
        return Interaction.InputBox(prompt, title);
    }

    /// <summary>
    /// メッセージボックス
    /// </summary>
    /// <param name="message">表示するメッセージ</param>
    /// <param name="title">タイトル</param>
    /// <returns>メッセージ文字列</returns>
    public static Primitive MsgBox(Primitive message, Primitive title)
    {
        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        return message;
    }
}
