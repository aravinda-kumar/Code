#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
}

MainWindow::~MainWindow()
{
//    delete a;
    delete ui;
}


void MainWindow::on_actionaddStu_triggered()
{
//    addStu a;
//    a.show();
//    //阻塞程序,主窗口无法进行操作
//    //模态试图
//    a.exec();
    //show出的对象不会被销毁
    this->a.show();
}

void MainWindow::on_actionQueryStu_triggered()
{
    queryStu q;
    q.exec();
}

void MainWindow::on_actionAbout_triggered()
{
    QMessageBox::aboutQt(this, "鸣谢");
}

void MainWindow::on_actionHelp_triggered()
{
    help p;
    p.exec();
}
