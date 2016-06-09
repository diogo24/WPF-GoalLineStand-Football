Public Class SettingsUI
    Inherits DependencyObject

    Public shared readonly _
        EnableSalCapProperty As DependencyProperty = DependencyProperty.Register("EnabSalCap", GetType(Boolean),
                                                                                 GetType(GameSettings),
                                                                                 New PropertyMetadata("True"))

    Public Shared ReadOnly _
        SalCapTypeProperty As DependencyProperty = DependencyProperty.Register("SalCapType", GetType(String),
                                                                               GetType(GameSettings),
                                                                               New PropertyMetadata("HardCap"))

    Public Property EnabSalCap As Boolean
        Get
            Return CBool(GetValue(EnableSalCapProperty))
        End Get
        Set
            SetValue(EnableSalCapProperty, value)
        End Set
    End Property

    Public Property SalCapType As string
        Get
            Return Cstr(GetValue(SalCapTypeProperty))
        End Get
        Set
            SetValue(SalCapTypeProperty, value)
        End Set
    End Property
End Class
