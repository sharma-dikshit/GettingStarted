#include <Windows.h>
#include <iostream>

int DisplayMessageBox()
{
    int msgboxID = MessageBox(
        NULL,
        (LPCWSTR)L"This is a sample message box \n Click on any button to proceed !",
        (LPCWSTR)L"My Message Box",
        MB_ICONWARNING | MB_CANCELTRYCONTINUE | MB_DEFBUTTON2
    );

    switch (msgboxID)
    {
    case IDCANCEL:
        std::cout << "You clicked on the cancel button !" << std::endl;
        break;
    case IDTRYAGAIN:
        std::cout << "You clicked on the Try Again button !" << std::endl;
        break;
    case IDCONTINUE:
        std::cout << "You clicked on the Continue button !" << std::endl;
        break;
    }

    return msgboxID;
}

int main() {
    DisplayMessageBox();

    return 0;
}