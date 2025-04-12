using UnityEngine;

namespace Services
{
    public sealed class ClipboardManager
    {
        /// <summary>
        /// Копирует указанный текст в буфер обмена.
        /// </summary>
        /// <param name="text">Текст для копирования.</param>
        public static void CopyToClipboard(string text)
        {
            GUIUtility.systemCopyBuffer = text;
            Debug.Log($"Text copied to clipboard: {text}");
        }

        /// <summary>
        /// Возвращает текущий текст из буфера обмена.
        /// </summary>
        /// <returns>Строка, содержащая текущий текст из буфера обмена.</returns>
        public static string GetClipboardText()
        {
            return GUIUtility.systemCopyBuffer;
        }
    }
}