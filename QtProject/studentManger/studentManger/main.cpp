#include "addstu.h"
#include <QApplication>
#include "mainwindow.h"

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
//    addStu w;
//    w.show();
    MainWindow main;
    main.show();

    //程序在此循环
    return a.exec();
}
