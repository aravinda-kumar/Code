#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QTime>
#include <QTimer>
#include <QString>

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
    void updateTimerandDisplay();

    void on_btnSatrt_clicked();

    void on_btnStop_clicked();

    void on_btnPause_clicked();

    void on_btnRecord_clicked();

private:
    Ui::MainWindow *ui;
    QTimer *ptimer;
    QTime basetime;
    QString showStr;
    int stopState=0;
    int pauseState=0;
};

#endif // MAINWINDOW_H
