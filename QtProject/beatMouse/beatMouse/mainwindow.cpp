#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    this->score = 0;
    ui->setupUi(this);
    this->sc = new myScene();
    this->ui->graphicsView->setScene(this->sc);
    //按钮的信号与槽
    connect(this->ui->btnStart, SIGNAL(clicked(bool)), this->sc,SLOT(StartGame()));
    connect(this->ui->btnPause, SIGNAL(clicked(bool)), this->sc,SLOT(PauseGame()));
    connect(this->ui->btnStop, SIGNAL(clicked(bool)), this->sc,SLOT(StopGame()));

    handler *hand = handler::getInstance();
    connect(hand, SIGNAL(beatMouse()), this, SLOT(upDateScore()));
}

MainWindow::~MainWindow()
{
    delete ui;
}

void MainWindow::upDateScore()
{
    this->score += 10;
    this->ui->lcdNumber->display(this->score);
}
