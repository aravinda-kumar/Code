#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    connect(this->ui->btn0, SIGNAL(clicked(bool)), this, SLOT(getBtn0()));
    connect(this->ui->btn1, SIGNAL(clicked(bool)), this, SLOT(getBtn1()));
    connect(this->ui->btn2, SIGNAL(clicked(bool)), this, SLOT(getBtn2()));
    this->tmp = "";
    this->mode = new model;
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::getBtn0()
{
    //对于非bool类型的获取是属性名称本身
    //设置就是set+属性名
    if(this->tmp != "")
    {
        this->tmp += this->ui->btn0->text();
        this->ui->lblDisplay->setText(this->tmp);
    }
}

void MainWindow::getBtn1()
{
    this->tmp += this->ui->btn1->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::getBtn2()
{
    this->tmp += this->ui->btn2->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn3_clicked()
{
    this->tmp += this->ui->btn3->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn4_clicked()
{
    this->tmp += this->ui->btn4->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn5_clicked()
{
    this->tmp += this->ui->btn5->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn6_clicked()
{
    this->tmp += this->ui->btn6->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn7_clicked()
{
    this->tmp += this->ui->btn7->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn8_clicked()
{
    this->tmp += this->ui->btn8->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btn9_clicked()
{
    this->tmp += this->ui->btn9->text();
    this->ui->lblDisplay->setText(this->tmp);
}

void MainWindow::on_btnAdd_clicked()
{
    int num = this->tmp.toInt();
    this->mode->setNum1(num);
    this->tmp = "";
    QString ex = this->ui->btnAdd->text();
    this->mode->setFlag(ex);
    this->ui->lblDisplay->setText(ex);
}

void MainWindow::on_btnSub_clicked()
{
    int num = this->tmp.toInt();
    this->mode->setNum1(num);
    this->tmp = "";
    QString ex = this->ui->btnSub->text();
    this->mode->setFlag(ex);
    this->ui->lblDisplay->setText(ex);
}

void MainWindow::on_btnMul_clicked()
{
    int num = this->tmp.toInt();
    this->mode->setNum1(num);
    this->tmp = "";
    QString ex = this->ui->btnMul->text();
    this->mode->setFlag(ex);
    this->ui->lblDisplay->setText(ex);
}

void MainWindow::on_btnDiv_clicked()
{
    int num = this->tmp.toInt();
    this->mode->setNum1(num);
    this->tmp = "";
    QString ex = this->ui->btnDiv->text();
    this->mode->setFlag(ex);
    this->ui->lblDisplay->setText(ex);
}

void MainWindow::on_btnEqual_clicked()
{
    int num = this->tmp.toInt();
    this->mode->setNum2(num);
    this->tmp = "";
    this->ui->lblDisplay->setText(this->mode->doExpr());
}

void MainWindow::on_btnAC_clicked()
{
    this->ui->lblDisplay->setText("0");
    this->tmp = "";
}
