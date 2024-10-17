#include "mainwindow.h"
#include "ui_mainwindow.h"

MainWindow::MainWindow(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::MainWindow)
{
    ui->setupUi(this);
    QScreen *screen = QGuiApplication::primaryScreen();
    QRect  screenGeometry = screen->geometry();
    OX = 400; //начало координат
    OY = 500;
    OZ = 0;
    deltaX = 0; //отклонение от начала, нужно для масштабирования относительно точки
    deltaY = 0;
    deltaZ = 0;
    this->ui->lineEdit_3->setText("1");
    this->ui->lineEdit_4->setText("1");
    this->ui->lineEdit_5->setText("1");
    proection =
    {
        { 1, 0, 0, 0},                               //матрица проекции
        { 0, -1, 0, 0},
        { -(qCos(PI/4))/2, (qCos(PI/4))/2, 0, 0},
        { OX, OY, 0Z, 1}
    };
    startPosition();
    schetchik=0;
    interval = 10;
    tmr = new QTimer(this);
    tmr->setInterval(interval); // интервал в мс
    connect(tmr, SIGNAL(timeout()), this, SLOT(animacionnoeMashtabirovanie()));

}

MainWindow::~MainWindow()
{
    delete ui;
}

QVector<QVector<float>> MainWindow::Mult( QVector<QVector<float>> X,  QVector<QVector<float>> Y)
{
    QVector<QVector<float>> result (X.length(), QVector<float>(Y[0].length()));     //умножение матриц
    for (int i = 0; i < X.length(); i++)
        for (int j = 0; j < Y[0].length(); j++)
            for (int k = 0; k < Y[0].length(); k++)
                result[i][j] += X[i][k] * Y[k][j];
    return result;
}

void MainWindow::paintEvent(QPaintEvent *event)
{
    QPainter painter(this);                 //рисовалка осей и елки
    QColor coordLineColor(0,0,0, 255);
    QPen apen = QPen(coordLineColor);
    QVector<QVector<float>> OSI =
        {
            { 0, 0, 0, 1},       //(X0,Y0,Z0)
            { 500, 0, 0, 1},     //(X1,Y0,Z0)
            { 0, 400, 0, 1},     //(X0,Y1,Z0)
            { 0, 0, 500, 1},     //(X0,Y0,Z1)
            { 490, 5, 0, 1},     //Рисование стрелочек
            { 490, -5, 0, 1},
            { 5, 390, 0, 1},
            { -5, 390, 0, 1},
            { 12, 0, 495, 1},
            { -10, 0, 480, 1}
        };
    OSI = Mult(OSI, proection);

    painter.drawLine(OSI[0][0], OSI[0][1], OSI[1][0], OSI[1][1]);   //рисует ось
    painter.drawLine(OSI[1][0], OSI[1][1], OSI[4][0], OSI[4][1]);   //рисует стрелки
    painter.drawLine(OSI[1][0], OSI[1][1], OSI[5][0], OSI[5][1]);   //

    painter.drawLine(OSI[0][0], OSI[0][1], OSI[2][0], OSI[2][1]);   //
    painter.drawLine(OSI[2][0], OSI[2][1], OSI[6][0], OSI[6][1]);   //
    painter.drawLine(OSI[2][0], OSI[2][1], OSI[7][0], OSI[7][1]);   //

    painter.drawLine(OSI[0][0], OSI[0][1], OSI[3][0], OSI[3][1]);   //
    painter.drawLine(OSI[3][0], OSI[3][1], OSI[8][0], OSI[8][1]);   //
    painter.drawLine(OSI[3][0], OSI[3][1], OSI[9][0], OSI[9][1]);   //

    apen.setColor("red");
    apen.setWidth(2);
    painter.setPen(apen);

    QVector<QVector<float>> matritcaRisovaniya = Mult(Elka, proection);
    for (int i = 0; i < 10; i++)
    {
        painter.drawLine(matritcaRisovaniya[i][0], matritcaRisovaniya[i][1], matritcaRisovaniya[i + 1][0], matritcaRisovaniya[i + 1][1]);
        painter.drawLine(matritcaRisovaniya[i+11][0], matritcaRisovaniya[i+11][1], matritcaRisovaniya[i + 12][0], matritcaRisovaniya[i + 12][1]);
        painter.drawLine(matritcaRisovaniya[i][0], matritcaRisovaniya[i][1], matritcaRisovaniya[i + 11][0], matritcaRisovaniya[i + 11][1]);
    }
    painter.drawLine(matritcaRisovaniya[0][0], matritcaRisovaniya[0][1], matritcaRisovaniya[10][0], matritcaRisovaniya[10][1]);
    painter.drawLine(matritcaRisovaniya[11][0], matritcaRisovaniya[11][1], matritcaRisovaniya[21][0], matritcaRisovaniya[21][1]);
    painter.drawLine(matritcaRisovaniya[10][0], matritcaRisovaniya[10][1], matritcaRisovaniya[21][0], matritcaRisovaniya[21][1]);
}

//начальные значения точек Елки
 void MainWindow::startPosition()
{
    Elka =
        {
            { 0, 0, 0, 1 },      //A - 0
            { 0, 10, 0, 1 },     //B - 1
            {-20, 10, 0, 1 },    //C - 2
            { 0, 30, 0, 1 },     //D - 3
            { -10, 30, 0, 1 },   //E - 4
            { 5, 50, 0, 1 },     //F - 5
            { 20, 30, 0, 1 },    //G - 6
            { 10, 30, 0, 1 },    //H - 7
            { 30, 10, 0, 1 },    //I - 8
            { 10, 10, 0, 1 },    //J - 9
            { 10, 0, 0, 1 },     //K - 10
            { 0, 0, 10, 1 },     //A1 - 11
            { 0, 10, 10, 1 },    //B1 - 12
            { -20, 10, 10, 1 },  //C1 - 13
            { 0, 30, 10, 1 },    //D1 - 14
            { -10, 30, 10, 1 },  //E1 - 15
            { 5, 50, 10, 1 },    //F1 - 16
            { 20, 30, 10, 1 },   //G1 - 17
            { 10, 30, 10, 1 },   //H1 - 18
            { 30, 10, 10, 1 },   //I1 - 19
            { 10, 10, 10, 1 },   //J1 - 20
            { 10, 0, 10, 1 }     //K1 - 21
        };
    deltaX = 0;
    deltaY = 0;
    deltaZ = 0;
}

void MainWindow::on_pushButton_clicked() //возврат на начальную позицию
{
    startPosition();
    this->repaint();
}

void MainWindow::on_dvigatX_clicked() //движение по осям
{
    int podvinut = this->ui->lineEdit->text().toInt();
    QVector<QVector<float>> Move =
    {
       { 1, 0, 0, 0},
        { 0, 1, 0, 0},
        { 0, 0, 1, 0},
        { podvinut, 0, 0, 1}
    };
    Elka = Mult(Elka, Move);
    deltaX += podvinut;
    this->repaint();
}

void MainWindow::on_dvigatY_clicked()
{
    int podvinut = this->ui->lineEdit->text().toInt();
    QVector<QVector<float>> Move =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { 0, podvinut, 0, 1}
        };
    Elka = Mult(Elka, Move);
    deltaY += podvinut;
    this->repaint();
}

void MainWindow::on_dvigatZ_clicked()
{
    int podvinut = this->ui->lineEdit->text().toInt();
    QVector<QVector<float>> Move =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { 0, 0, podvinut, 1}
        };
    Elka = Mult(Elka, Move);
    deltaZ += podvinut;
    this->repaint();
}

void MainWindow::on_povorotX_clicked() //поворот
{
    int povernut = this->ui->lineEdit_2->text().toInt();
    float ugol = (povernut * PI /180);
     QVector<QVector<float>> povorot =
        {
            { 1, 0, 0, 0},
            { 0, (qCos(ugol)), (qSin(ugol)), 0},
            { 0, -(qSin(ugol)), (qCos(ugol)), 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, povorot);
    this->repaint();
}

void MainWindow::on_povorotY_clicked()
{
    int povernut = this->ui->lineEdit_2->text().toInt();
    float ugol = (povernut * PI /180);
    QVector<QVector<float>> povorot =
        {
            { ((qCos(ugol))), 0, ((qSin(ugol))), 0},
            { 0, 1, 0, 0},
            { -((qSin(ugol))), 0, ((qCos(ugol))), 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, povorot);
    this->repaint();
}

void MainWindow::on_povorotZ_clicked()
{
    int povernut = this->ui->lineEdit_2->text().toInt();
    float ugol = (povernut * PI /180);
    QVector<QVector<float>> povorot =
        {
            { ((qCos(ugol))), -((qSin(ugol))), 0, 0},
            { ((qSin(ugol))), ((qCos(ugol))), 0, 0},
            { 0, 0, 1, 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, povorot);
    this->repaint();
}

void MainWindow::on_OtrazitZ_clicked() //отражение относительно осей
{
    QVector<QVector<float>> zerkalit =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, -1, 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, zerkalit);
    this->repaint();
}

void MainWindow::on_OtrazitY_clicked()
{
    QVector<QVector<float>> zerkalit =
        {
          { 1, 0, 0, 0},
          { 0, -1, 0, 0},
          { 0, 0, 1, 0},
          { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, zerkalit);
    this->repaint();
}

void MainWindow::on_OtrazitX_clicked()
{
    QVector<QVector<float>> zerkalit =
        {
            { -1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, zerkalit);
    this->repaint();
}

void MainWindow::on_szhat_clicked()  //масштабирование(уменьшение в 2 раза)
{
    QVector<QVector<float>> szhatie =
        {
            { 0.5, 0, 0, 0},
            { 0, 0.5, 0, 0},
            { 0, 0, 0.5, 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, szhatie);
    this->repaint();
}

void MainWindow::on_rastanut_clicked()
{    //увеличение в 2 раза
    QVector<QVector<float>> Rastagivanie =
        {
            { 2, 0, 0, 0},
            { 0, 2, 0, 0},
            { 0, 0, 2, 0},
            { 0, 0, 0, 1}
        };
    Elka = Mult(Elka, Rastagivanie);
    this->repaint();
}

void MainWindow::on_mashtabirovat_clicked()
{
    tmr->start(); // Запускаем таймер
    animacionnoeMashtabirovanie();
}

void MainWindow::animacionnoeMashtabirovanie()
{
    float koefX = this->ui->lineEdit_3->text().toFloat();
    float koefY = this->ui->lineEdit_4->text().toFloat();
    float koefZ = this->ui->lineEdit_5->text().toFloat();
    float shagX = qPow(koefX, 0.01); //разбиваю масштаб на 100 шагов
    float shagY = qPow(koefY, 0.01);
    float shagZ = qPow(koefZ, 0.01);
    QVector<QVector<float>> Rastagivanie =
        {
            { shagX, 0, 0, 0},
            { 0,  shagY, 0, 0},
            { 0, 0, shagZ, 0},
            { 0, 0, 0, 1}
        };
    QVector<QVector<float>> Peremeshenie =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { -deltaX,  - deltaY,  - deltaZ, 1}
        };
    QVector<QVector<float>> ObratnoePeremeshenie =
        {
            { 1, 0, 0, 0},
            { 0, 1, 0, 0},
            { 0, 0, 1, 0},
            { +deltaX,  + deltaY,  + deltaZ, 1}
        };
    Elka = Mult(Elka, Peremeshenie);
    Elka = Mult(Elka, Rastagivanie);
    Elka = Mult(Elka, ObratnoePeremeshenie);
    this->repaint();
    schetchik+=1;
    if(schetchik==100) //увеличение происходит в 100 шагов
    {
        tmr->stop();
        schetchik=0;
        interval = 10;
    }
    if(schetchik==70) //замедление перед остановкой
    {
        interval += 20;
        tmr->setInterval(interval);
    }

}


