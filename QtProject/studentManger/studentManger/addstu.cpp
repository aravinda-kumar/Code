#include "addstu.h"
#include "ui_addstu.h"
#include <QString>
#include <QDebug>
#include <QMessageBox>
#include <QPushButton>

addStu::addStu(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::addStu)
{
    ui->setupUi(this);
}

addStu::~addStu()
{
    delete ui;
}

void addStu::on_btn_OK_clicked()
{
    QString name = this->ui->le_Name->text();
    QString id = this->ui->le_ID->text();
    QString age = this->ui->cbb_Age->currentText();
    QString school = this->ui->cbb_School->currentText();

    QString content = "姓名:\t"+name+"\nID:\t"+id + "\n年龄:\t" + age + "\n学院\t"+ school;
    if(name.length() <1 || id.length() < 1)
        QMessageBox::critical(this, "错误", "信息填写不完整，请检查", "确定");
    else
    {
        int ret = QMessageBox::question(this, "请确认信息", content, "确认", "取消");
        qDebug() << ret;
    }
}

void addStu::on_btn_Cancel_clicked()
{
    this->close();
}

