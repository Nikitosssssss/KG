#ifndef MAINWINDOW_H
#define MAINWINDOW_H

#include <QMainWindow>
#include <QPainter>
#include <QScreen>
#include <QtMath>
#include <QTimer>
#include <QTime>

QT_BEGIN_NAMESPACE
namespace Ui {
class MainWindow;
}
QT_END_NAMESPACE

class MainWindow : public QMainWindow
{
    Q_OBJECT

public:
    MainWindow(QWidget *parent = nullptr);
    ~MainWindow();
    void paintEvent(QPaintEvent *);
    QVector<QVector<float>> Mult( QVector<QVector<float>> X,  QVector<QVector<float>> Y);
    void startPosition();


private slots:
    void on_pushButton_clicked();

    void on_dvigatX_clicked();

    void on_dvigatY_clicked();

    void on_dvigatZ_clicked();

    void on_povorotX_clicked();

    void on_povorotY_clicked();

    void on_povorotZ_clicked();

    void on_OtrazitZ_clicked();

    void on_OtrazitY_clicked();

    void on_OtrazitX_clicked();

    void on_szhat_clicked();

    void on_rastanut_clicked();

    void on_mashtabirovat_clicked();

    void animacionnoeMashtabirovanie();

private:
    Ui::MainWindow *ui;
    int OX, OY, OZ;
    QVector<QVector<float>> proection;
    QVector<QVector<float>> Elka;
    double PI = 3.14;
    QBrush brush{"#006400"};
    int deltaX,deltaY,deltaZ;
    QTimer *tmr;
    int schetchik;
    int interval;
};
#endif // MAINWINDOW_H
