Public Class Main

    ''' <summary>
    ''' フォーム画面の名前を設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "【株式会社 CFS】社員管理画面"
    End Sub

    ''' <summary>
    ''' 管理者に問い合わせ
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SendMail_Click(sender As Object, e As EventArgs) Handles SendMail.Click

        'メールボックスを表示する

        Dim addr As String = "" 'アドレス
        Dim subject As String = "" '件名
        Dim body As String = "" '本文

        addr = "loveladygaga0602@gmail.com" '一先ず固定値で入力

        ''件名 固定値にしておく
        subject = "【社員情報管理画面】問い合わせ"

        ''本文
        body = body & "システム情報部 大阪様"
        body = body & "" & "%0D%0A"
        body = body & "お問い合わせしたいことがありますので、メールを送信させていただきます。

 "
        System.Diagnostics.Process.Start("mailto:" & addr & "?subject=" & subject & "&body =" + body)
    End Sub

    ''' <summary>
    ''' 関西支店の社員マスタ画面に遷移する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SyainM_Kansai_Click(sender As Object, e As EventArgs) Handles SyainM_Kansai.Click

        Dim gamen As New SyainM
        gamen.ShowDialog(Me)
        gamen.Dispose()

    End Sub
End Class