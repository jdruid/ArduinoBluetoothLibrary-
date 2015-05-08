// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF 
// ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A 
// PARTICULAR PURPOSE. 
// 
// Copyright (c) Microsoft Corporation. All rights reserved 
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Windows.UI;
using Windows.UI.Xaml.Media;

using ArduinoBluetooth.Connection; //BluetoothConnectionState

// Code used from Bluetooth communication between Arduino and Windows 8.1
// Author: Michael Osthege
// http://code.msdn.microsoft.com/Bluetooth-communication-7130c260/sourcecode?fileId=97047&pathId=464830490

namespace ArduinoBluetooth.Converter
{
    public class BluetoothStateConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string culture)
        {
            switch (parameter as string)//parameter tells us who's calling
            {
                //BluetoothConnectionState
                case "BluetoothConnect": return ((BluetoothConnectionState)value == BluetoothConnectionState.Disconnected);
                case "BluetoothInProgress":
                case "BluetoothConnecting": return ((BluetoothConnectionState)value == BluetoothConnectionState.Connecting);
                case "BluetoothDisconnect": return ((BluetoothConnectionState)value == BluetoothConnectionState.Connected);
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string culture)
        {
            return null;
        }
    }
}


