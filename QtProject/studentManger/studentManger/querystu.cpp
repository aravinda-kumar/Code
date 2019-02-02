#include "querystu.h"
#include "ui_querystu.h"

queryStu::queryStu(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::queryStu)
{
    ui->setupUi(this);
    if(readFromFile() == -1)
    {
        QMessageBox::critical(this, "错误", "文件打开失败，请重试！", "确认");
        //在构造函数中退出应用程序
        QTimer::singleShot(0,qApp,SLOT(quit()));
    }
    this->model = new QStandardItemModel();

    this->SetTableHeader();
}

queryStu::~queryStu()
{
    delete ui;
}


int queryStu::readFromFile()
{
    QFile file("stu.txt");
    if (!file.open(QIODevice::ReadOnly | QIODevice::Text))
        return -1;

    QTextStream in(&file);
    //判读文件是否读到文件结尾
    while (!in.atEnd())
    {
        QString line = in.readLine();
        stuLines.append(line);
    }
    file.close();


    return 0;
}

void queryStu::on_btnSearch_clicked()
{
    int index = this->ui->cbbMethod->currentIndex();
    QString cnt = this->ui->leCnt->text();
    this->doQuery(index, cnt);
}

void queryStu::doQuery(int index, QString cnt)
{
    int flag = 0;

    if(index == 0)
    {
        QMessageBox::information(this, "提示", "请选择查询方式", "确认");
    }
    else
    {
        for(int i=0;i<stuLines.length();i++)
        {
            QString line = stuLines.at(i).trimmed();
            QStringList subs = line.split(' ', QString::SkipEmptyParts);
            switch (index)
            {
            case 1:
                if(cnt == subs.at(0))
                {
                    Display(this->row++, subs);
                    flag = 1;
                }
                break;
            case 2:
                if(cnt == subs.at(1))
                {
                    Display(this->row++, subs);
                    flag = 1;
                }
                break;
            case 3:
                if(cnt == subs.at(4))
                {
                    Display(this->row++, subs);
                    flag = 1;
                }
                break;
            }
        }
        if(flag == 0)
        {
            QMessageBox::information(this, "提示", "查无此人", "确认");
        }
    }
}

void queryStu::Display(int row, QStringList subs)
{
    for(int i=0;i<subs.length();i++)
    {
        this->model->setItem(row, i,new QStandardItem(subs.at(i)));
    }
}

void queryStu::on_btnClear_clicked()
{
    this->model->clear();
    this->row = 0;
    this->SetTableHeader();
}

void queryStu::SetTableHeader()
{
    this->model->setHorizontalHeaderItem(0, new QStandardItem("姓名"));
    this->model->setHorizontalHeaderItem(1, new QStandardItem("学号"));
    this->model->setHorizontalHeaderItem(2, new QStandardItem("性别"));
    this->model->setHorizontalHeaderItem(3, new QStandardItem("年龄"));
    this->model->setHorizontalHeaderItem(4, new QStandardItem("院系"));
    this->model->setHorizontalHeaderItem(5, new QStandardItem("兴趣"));

    //进行绑定
    this->ui->tableView->setModel(model);

    //设置表头宽度
    this->ui->tableView->setColumnWidth(0, 100);
    this->ui->tableView->setColumnWidth(1, 150);
    this->ui->tableView->setColumnWidth(2, 50);
    this->ui->tableView->setColumnWidth(3, 50);
    this->ui->tableView->setColumnWidth(4, 100);
    this->ui->tableView->setColumnWidth(5, 200);
}
