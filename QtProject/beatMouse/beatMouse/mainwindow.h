#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "myscene.h"
#include <QCloseEvent>
#include <QMessageBox>
#include "handler.h"

namespace Ui {
class MainWindow;
}

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit MainWindow(QWidget *parent = nullptr);
    ~MainWindow();

private slots:
    void upDateScore();

private:
    Ui::MainWindow *ui;
    myScene *sc;
    int score;

};

#endif // MAINWINDOW_H
