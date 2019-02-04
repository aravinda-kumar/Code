#include "myscene.h"

myScene::myScene(QObject *parent) : QGraphicsScene(parent)
{
    for(int i=0;i<4;i++)
    {
        for(int j=0;j<4;j++)
        {
            this->item[i*4+j] = new myitem();
            this->item[i*4+j]->setPos(i*91, j*91);
            this->item[i*4+j]->SetMouse(false);
            this->addItem(this->item[i*4+j]);
        }
    }

    this->ptimer = new QTimer();
    connect(this->ptimer, SIGNAL(timeout()), this,SLOT(showMouse()));

}

void myScene::showMouse()
{
    for(int i=0;i<16;i++)
    {
        this->item[i]->setPic(":/bg/pic/bg1.png");
        this->item[i]->SetMouse(false);
    }
    //产生一个随机数字0~15
    int count = rand()%3+1;
    for(int i=0;i<count;i++)
    {
        int index = rand()%16;
        this->item[index]->SetMouse(true);
        this->item[index]->setPic(":/bg/pic/mouse");
    }
}

void myScene::StartGame()
{
    this->ptimer->start(800);
    for(int i=0;i<16;i++)
    {
        this->item[i]->SetStart(true);
    }
}

void myScene::PauseGame()
{
    this->ptimer->stop();
    for(int i=0;i<16;i++)
    {
        this->item[i]->SetStart(false);
    }
}

void myScene::StopGame()
{
    handler *hand = handler::getInstance();
    hand->clearScore();
    this->ptimer->stop();
    for(int i=0;i<16;i++)
    {
        this->item[i]->SetStart(false);
        this->item[i]->setPic(":/bg/pic/bg1.png");
        this->item[i]->SetMouse(false);
    }
}
