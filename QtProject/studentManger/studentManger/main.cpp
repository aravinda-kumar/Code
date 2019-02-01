#include "addstu.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    addStu w;
    w.show();

    return a.exec();
}
