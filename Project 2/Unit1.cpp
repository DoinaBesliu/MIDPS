//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
#include "dos.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
struct date d;
struct time t;
int i;
int sec=0,min=0,hour=0,decisec=0,count=0;
char current[20];




//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button4Click(TObject *Sender)
{
Close();        
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
char buf[20];
getdate(&d);
gettime(&t);
sprintf(buf,"%02d-%02d-%4d %02d:%02d:%02d",d.da_day,d.da_mon,d.da_year,
t.ti_hour,t.ti_min,t.ti_sec);
Edit1->Text=(AnsiString)buf;

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button1Click(TObject *Sender)
{
Timer2->Enabled=true;
Button1->Enabled=false;
Timer2->Enabled=true;
Button2->Enabled=true;
Button3->Enabled=false;
}
//---------------------------------------------------------------------------


void __fastcall TForm1::Button2Click(TObject *Sender)
{
Button2->Enabled=false;
Button1->Enabled=true;
Button3->Enabled=true;
Button1->Caption="CONTINUE";
Timer2->Enabled=false;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button3Click(TObject *Sender)
{
Button3->Enabled=false;
Button2->Enabled=false;
Button1->Enabled=true;
Button1->Caption="START";
i=0;
sec=0;
min=0;
hour=0;
Edit2->Text=0;
}
//---------------------------------------------------------------------------



void __fastcall TForm1::Timer2Timer(TObject *Sender)
{
i++;
////////////
if(i==9)
{sec++;
i=0;}
/////////////
if(sec==59){
min++;
sec=0;}
/////////////
if(min==59){
hour++;
min=0;
}  
sprintf(current,"%d ore %d min %d sec %d zec",hour,min,sec,i);
Edit2->Text=(AnsiString)current;


}
//---------------------------------------------------------------------------

