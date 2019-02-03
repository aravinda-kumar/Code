#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QDebug>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    ptimer = new QTimer();
    connect(this->ptimer, SIGNAL(timeout()), this, SLOT(updateTimerandDisplay()));
}

MainWindow::~MainWindow()
{
    delete ui;
    delete ptimer;
}

void MainWindow::updateTimerandDisplay()
{
    QTime current = QTime::currentTime();
    int t = this->basetime.msecsTo(current);
    QTime showTime(0,0,0);
    showTime = showTime.addMSecs(t);
    showStr = showTime.toString("hh:mm:ss:zzz");
    this->ui->lcdNumber->display(showStr);
}

void MainWindow::on_btnSatrt_clicked()
{
    this->basetime = QTime::currentTime();
    this->ptimer->start(1);
}

void MainWindow::on_btnStop_clicked()
{
    if(this->stopState == 0)
    {
        //对暂停操作进行一定的设置
        this->ui->btnPause->setEnabled(false);
        this->ui->btnPause->setText("暂停");
        pauseState = 0;

        this->ptimer->stop();
        this->ui->btnStop->setText("清零");
        this->ui->btnSatrt->setEnabled(false);
        stopState++;
    }
    else
    {
        QTime showTime(0,0,0);
        showStr = showTime.toString("hh:mm:ss:zzz");
        this->ui->lcdNumber->display(showStr);
        this->ui->btnStop->setText("停止");
        this->ui->btnSatrt->setEnabled(true);
        this->ui->btnPause->setEnabled(true);
        this->ui->textBrowser->clear();
        stopState = 0;
    }
}

void MainWindow::on_btnPause_clicked()
{
    static QTime pauseTime;
    if(this->pauseState == 0)
    {
        pauseTime = QTime::currentTime();
        this->ui->btnPause->setText("继续");
        this->ui->btnSatrt->setEnabled(false);
        //this->ui->btnStop->setEnabled(false);
        this->ptimer->stop();
        pauseState++;
    }
    else
    {
        QTime nowTime = QTime::currentTime();
        int t = pauseTime.msecsTo(nowTime);
        this->basetime = this->basetime.addMSecs(t);
        this->ui->btnPause->setText("暂停");
        this->ui->btnSatrt->setEnabled(true);
        //this->ui->btnStop->setEnabled(true);
        this->ptimer->start(1);
        pauseState = 0;
    }
}

void MainWindow::on_btnRecord_clicked()
{
    this->ui->textBrowser->append(showStr);
}
