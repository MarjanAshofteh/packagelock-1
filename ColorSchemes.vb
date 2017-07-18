﻿Public Class ColorSchemes
    Public Shared SelectedNormal As Color() = New Color() {Color.FromArgb(255, 237, 156), Color.FromArgb(255, 237, 156), Color.FromArgb(255, 216, 108), Color.FromArgb(255, 196, 0), Color.White}

    Public Shared SelectedHover As Color() = New Color() {Color.FromArgb(255, 237, 156), Color.FromArgb(255, 247, 166), Color.FromArgb(255, 216, 118), Color.FromArgb(255, 230, 50), Color.White}

    Public Shared SelectedPressed As Color() = New Color() {Color.FromArgb(225, 207, 126), Color.FromArgb(255, 227, 136), Color.FromArgb(255, 192, 35), Color.Gold, Color.White}

    Public Shared SelectedBorder As SolidBrush = New SolidBrush(Color.DarkGray)

    Public Shared UnSelectedNormal As Color() = New Color() {Color.FromArgb(90, 90, 90), Color.FromArgb(110, 110, 110), Color.FromArgb(130, 130, 130), Color.FromArgb(110, 110, 110), Color.FromArgb(90, 90, 90)}

    'Public Shared UnSelectedHover As Color() = New Color() {Color.FromArgb(235, 244, 253), Color.FromArgb(221, 236, 253), Color.FromArgb(209, 230, 253), Color.FromArgb(194, 220, 253), Color.White}
    Public Shared UnSelectedHover As Color() = New Color() {Color.FromArgb(130, 130, 130), Color.FromArgb(150, 150, 150), Color.FromArgb(170, 170, 170), Color.FromArgb(150, 150, 150), Color.FromArgb(130, 130, 130)}

    Public Shared UnSelectedPressed As Color() = New Color() {Color.FromArgb(171, 210, 242), Color.FromArgb(194, 220, 253), Color.FromArgb(189, 210, 233), Color.FromArgb(194, 220, 253), Color.White}

    Public Shared UnSelectedBorder As SolidBrush = New SolidBrush(Color.DarkGray)

    Public Shared DisabledBorder As SolidBrush = New SolidBrush(Color.DarkGray)

    Public Shared DisabledAllColor As Color() = New Color() {Color.White, Color.White, Color.White, Color.White, Color.White}

End Class
