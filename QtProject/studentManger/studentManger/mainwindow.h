#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include "addstu.h"
#include "querystu.h"
#include <QMessageBox>
#include "help.h"

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
    void on_actionaddStu_triggered();

    void on_actionQueryStu_triggered();

    void on_actionAbout_triggered();

    void on_actionHelp_triggered();

private:
    Ui::MainWindow *ui;
    addStu a;
//    addStu *a = new addStu();
};

#endif // MAINWINDOW_H
