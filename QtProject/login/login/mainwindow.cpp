#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QDebug>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
//    connect(谁，发出了什么信号，谁，执行了什么操作)
    connect(this->ui->btnOK, SIGNAL(clicked(bool)),this, SLOT(login()));
//    connect(this->ui->btnCancel, SIGNAL(clicked(bool)),this, SLOT(cancel()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::login()
{
    static int count = 0;
    QString name = this->ui->leAccount->text();
    QString passwd = this->ui->lePassword->text();
    if(name != "" && passwd != "")
    {
        if(name == "jack" && passwd == "1234")
        {
            this->ui->lblStaus->setText("登录成功");
        }
        else
        {
            this->ui->lblStaus->setText("登录失败");
        }if(name == "jack" && passwd == "1234")
        {
            this->ui->lblStaus->setText("登录成功");
        }
        else
        {
            this->ui->lblStaus->setText("登录失败");
            count++;
            if(count > 3)
            {
//                this->close();
                disconnect(this->ui->btnOK, SIGNAL(clicked(bool)), this, SLOT(login()));
            }
        }
    }

}

void MainWindow::cancel()
{
    this->close();
}

void MainWindow::on_btnCancel_clicked()
{
    this->close();
}
