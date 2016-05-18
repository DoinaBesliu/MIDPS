//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "dos.h"
#include <stdio.h>
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
int x,y,x1,y1,i=0,k;
struct date d;
struct time t;
char buff[30];
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
        gettime(&t);
        getdate(&d);
        sprintf(buff,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,t.ti_hour,t.ti_min,t.ti_sec);
        Edit1->Text=AnsiString(buff);
        }
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
        Close();
}
//---------------------------------------------------------------------------

void __fastcall TForm1::FormCreate(TObject *Sender)
{
        Timer2->Enabled=false;
        Panel1->Color=clBlack;
        //Panel2->Height=0;
        Panel2->Color=clGray;
        Button2->Enabled=false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        Timer2->Enabled=true;
        Button2->Enabled=true;
        Button1->Enabled=false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
        Timer2->Enabled=false;
        Button2->Enabled=false;
        Button1->Enabled=true;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
        PaintBox1->Canvas->Brush->Style=bsCross;
        PaintBox1->Canvas->Brush->Color=clBlack;
        PaintBox1->Canvas->Pen->Color=clRed;
        PaintBox1->Canvas->FloodFill(0,0,clBlack,fsBorder);
        y=rand() % 100;
        x=rand() % 7;
        if(i)
        {
        x+=x1;
        }
        if(i==0)
        PaintBox1->Canvas->MoveTo(0,10);
        else PaintBox1->Canvas->MoveTo(x1,y1);
        PaintBox1->Canvas->LineTo(x,y);
        x1=x;
        y1=y;
        i++;
        if(x==300)
        {
        PaintBox1->Repaint();
        i=0;
        }
        k=y-50;
        Panel2->Height=y;
}
//---------------------------------------------------------------------------


