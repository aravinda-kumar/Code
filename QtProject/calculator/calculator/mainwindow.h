#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <model.h>
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
    void getBtn0();
    void getBtn1();
    void getBtn2();

    void on_btn3_clicked();

    void on_btn4_clicked();

    void on_btn5_clicked();

    void on_btn6_clicked();

    void on_btn7_clicked();

    void on_btn8_clicked();

    void on_btn9_clicked();

    void on_btnAdd_clicked();

    void on_btnSub_clicked();

    void on_btnMul_clicked();

    void on_btnDiv_clicked();

    void on_btnEqual_clicked();

    void on_btnAC_clicked();

private:
    QString tmp;
    Ui::MainWindow *ui;
    model *mode;
};

#endif // MAINWINDOW_H
