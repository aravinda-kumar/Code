#include "addstu.h"
#include "ui_addstu.h"
#include <QString>
#include <QDebug>
#include <QMessageBox>
#include <QPushButton>
#include <QFile>
#include <QTextStream>
#include <QIODevice>

addStu::addStu(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::addStu)
{
    ui->setupUi(this);
    this->insGroup->addButton(this->ui->checkBox_1, 1);
    this->insGroup->addButton(this->ui->checkBox_2, 2);
    this->insGroup->addButton(this->ui->checkBox_3, 3);
    this->insGroup->addButton(this->ui->checkBox_4, 4);

    this->sexGroup->addButton(this->ui->rbtn_Male,1);
    this->sexGroup->addButton(this->ui->rbtn_Femal,2);
    //设置多选不互斥
    this->insGroup->setExclusive(false);
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
    QString sex = this->sexGroup->checkedButton()->text();

    QString ins;
    QList<QAbstractButton*> ins_list = this->insGroup->buttons();
    for(int i=0;i<ins_list.length();i++)
    {
        QAbstractButton* item = ins_list.at(i);
        if(item->isChecked())
        {
            ins += item->text() + ",";
        }
    }
    ins = ins.left(ins.length()-1);

    QString content = "姓名:\t"+name+"\nID:\t"+id + "\n性别:\t"+sex + "\n年龄:\t" + age + "\n学院\t"+ school + "\n兴趣\t" + ins;
    //为了便于后续的读取，文本的要重新进行格式化
    QString cnt = name + " " + id + " " + sex + " " + age + " " + school + " " + ins + "\n";
    if(name.length() <1 || id.length() < 10 || ins.length()<1)
        QMessageBox::critical(this, "错误", "信息填写不完整，请检查", "确定");
    else
    {
        int ret = QMessageBox::question(this, "请确认信息", content, "确认", "取消");
        if(ret == 0)
        {
            writeToFile(cnt);
            ClearUserInterface();
        }
    }
}

void addStu::on_btn_Cancel_clicked()
{
    this->close();
}

void addStu::ClearUserInterface()
{
    this->ui->le_Name->clear();
    this->ui->le_ID->clear();
    this->ui->rbtn_Male->setChecked(true);
    this->ui->cbb_Age->setCurrentIndex(0);
    this->ui->cbb_School->setCurrentIndex(0);

    QList<QAbstractButton *> ins_list = this->insGroup->buttons();
    for(int i=0;i<ins_list.length();i++)
    {
        QAbstractButton *item = ins_list.at(i);
        item->setChecked(false);
    }

    this->ui->le_Name->setFocus();
}

void addStu::writeToFile(QString cnt)
{
    QFile file("stu.txt");
    if(!file.open(QIODevice::Append | QIODevice::Text))
    {
        QMessageBox::critical(this, "错误", "文件打开失败", "确认");
        return;
    }
    QTextStream out(&file);
    out << cnt;
    file.close();
}
