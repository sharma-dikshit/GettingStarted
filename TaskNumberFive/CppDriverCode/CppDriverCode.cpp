#include "pch.h"

using namespace System;
using namespace System::Windows;

[STAThreadAttribute]
int main(array<System::String ^> ^args)
{

    wpfMessageBox::MessageBoxUI^ _window = gcnew wpfMessageBox::MessageBoxUI();
    Application^ _app = gcnew Application();

    _app->Run(_window);
    return 0;
}
