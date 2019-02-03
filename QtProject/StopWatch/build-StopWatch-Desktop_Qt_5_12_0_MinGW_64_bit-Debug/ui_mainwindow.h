/********************************************************************************
** Form generated from reading UI file 'mainwindow.ui'
**
** Created by: Qt User Interface Compiler version 5.12.0
**
** WARNING! All changes made in this file will be lost when recompiling UI file!
********************************************************************************/

#ifndef UI_MAINWINDOW_H
#define UI_MAINWINDOW_H

#include <QtCore/QVariant>
#include <QtWidgets/QApplication>
#include <QtWidgets/QHBoxLayout>
#include <QtWidgets/QLCDNumber>
#include <QtWidgets/QMainWindow>
#include <QtWidgets/QPushButton>
#include <QtWidgets/QTextBrowser>
#include <QtWidgets/QVBoxLayout>
#include <QtWidgets/QWidget>

QT_BEGIN_NAMESPACE

class Ui_MainWindow
{
public:
    QWidget *centralWidget;
    QVBoxLayout *verticalLayout;
    QLCDNumber *lcdNumber;
    QHBoxLayout *horizontalLayout;
    QPushButton *btnSatrt;
    QPushButton *btnStop;
    QPushButton *btnPause;
    QPushButton *btnRecord;
    QTextBrowser *textBrowser;

    void setupUi(QMainWindow *MainWindow)
    {
        if (MainWindow->objectName().isEmpty())
            MainWindow->setObjectName(QString::fromUtf8("MainWindow"));
        MainWindow->resize(550, 400);
        MainWindow->setMinimumSize(QSize(550, 400));
        MainWindow->setMaximumSize(QSize(550, 400));
        centralWidget = new QWidget(MainWindow);
        centralWidget->setObjectName(QString::fromUtf8("centralWidget"));
        verticalLayout = new QVBoxLayout(centralWidget);
        verticalLayout->setSpacing(6);
        verticalLayout->setContentsMargins(11, 11, 11, 11);
        verticalLayout->setObjectName(QString::fromUtf8("verticalLayout"));
        lcdNumber = new QLCDNumber(centralWidget);
        lcdNumber->setObjectName(QString::fromUtf8("lcdNumber"));
        lcdNumber->setLayoutDirection(Qt::LeftToRight);
        lcdNumber->setFrameShape(QFrame::Box);
        lcdNumber->setFrameShadow(QFrame::Raised);
        lcdNumber->setDigitCount(16);
        lcdNumber->setMode(QLCDNumber::Dec);
        lcdNumber->setSegmentStyle(QLCDNumber::Filled);
        lcdNumber->setProperty("value", QVariant(0.000000000000000));
        lcdNumber->setProperty("intValue", QVariant(0));

        verticalLayout->addWidget(lcdNumber);

        horizontalLayout = new QHBoxLayout();
        horizontalLayout->setSpacing(6);
        horizontalLayout->setObjectName(QString::fromUtf8("horizontalLayout"));
        btnSatrt = new QPushButton(centralWidget);
        btnSatrt->setObjectName(QString::fromUtf8("btnSatrt"));

        horizontalLayout->addWidget(btnSatrt);

        btnStop = new QPushButton(centralWidget);
        btnStop->setObjectName(QString::fromUtf8("btnStop"));

        horizontalLayout->addWidget(btnStop);

        btnPause = new QPushButton(centralWidget);
        btnPause->setObjectName(QString::fromUtf8("btnPause"));

        horizontalLayout->addWidget(btnPause);

        btnRecord = new QPushButton(centralWidget);
        btnRecord->setObjectName(QString::fromUtf8("btnRecord"));

        horizontalLayout->addWidget(btnRecord);


        verticalLayout->addLayout(horizontalLayout);

        textBrowser = new QTextBrowser(centralWidget);
        textBrowser->setObjectName(QString::fromUtf8("textBrowser"));
        QFont font;
        font.setPointSize(30);
        textBrowser->setFont(font);
        textBrowser->setLayoutDirection(Qt::LeftToRight);

        verticalLayout->addWidget(textBrowser);

        verticalLayout->setStretch(0, 2);
        verticalLayout->setStretch(1, 1);
        verticalLayout->setStretch(2, 8);
        MainWindow->setCentralWidget(centralWidget);

        retranslateUi(MainWindow);

        QMetaObject::connectSlotsByName(MainWindow);
    } // setupUi

    void retranslateUi(QMainWindow *MainWindow)
    {
        MainWindow->setWindowTitle(QApplication::translate("MainWindow", "\347\247\222\350\241\250", nullptr));
        btnSatrt->setText(QApplication::translate("MainWindow", "\345\274\200\345\247\213", nullptr));
        btnStop->setText(QApplication::translate("MainWindow", "\345\201\234\346\255\242", nullptr));
        btnPause->setText(QApplication::translate("MainWindow", "\346\232\202\345\201\234", nullptr));
        btnRecord->setText(QApplication::translate("MainWindow", "\346\211\223\347\202\271", nullptr));
    } // retranslateUi

};

namespace Ui {
    class MainWindow: public Ui_MainWindow {};
} // namespace Ui

QT_END_NAMESPACE

#endif // UI_MAINWINDOW_H
