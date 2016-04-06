object Form1: TForm1
  Left = 190
  Top = 122
  Width = 502
  Height = 385
  Caption = 'Form1'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 248
    Top = 16
    Width = 90
    Height = 13
    Caption = 'Data si ora curente'
  end
  object Label2: TLabel
    Left = 176
    Top = 56
    Width = 197
    Height = 13
    Caption = 'Resursele grafice ale mediului C++ Builder'
  end
  object PaintBox1: TPaintBox
    Left = 224
    Top = 120
    Width = 249
    Height = 185
  end
  object Button1: TButton
    Left = 24
    Top = 160
    Width = 65
    Height = 25
    Caption = 'Start'
    TabOrder = 0
  end
  object Button2: TButton
    Left = 24
    Top = 200
    Width = 65
    Height = 25
    Caption = 'Stop'
    TabOrder = 1
  end
  object Button3: TButton
    Left = 24
    Top = 240
    Width = 65
    Height = 25
    Caption = 'Exit'
    TabOrder = 2
    OnClick = Button3Click
  end
  object Edit1: TEdit
    Left = 248
    Top = 32
    Width = 145
    Height = 21
    TabOrder = 3
  end
  object Panel1: TPanel
    Left = 128
    Top = 120
    Width = 41
    Height = 185
    TabOrder = 4
  end
  object Timer1: TTimer
    Left = 16
    Top = 8
  end
  object Timer2: TTimer
    Left = 16
    Top = 48
  end
end
