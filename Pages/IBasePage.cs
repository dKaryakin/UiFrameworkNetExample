﻿namespace Pages
{
    public interface IBasePage
    {
        void Click(string elementName);
        void OpenPage();
        void ClickCollectionElement(string collectionnName, int elementOrder);
        void SendText(string elementName, string text);
    }
}