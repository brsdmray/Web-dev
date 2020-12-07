
@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <title>@ViewBag.Title</title>
    <link href="~/Content/css/style.css" rel="stylesheet" />
</head>
<body>
    <section id="container">
        <header>
            <a href="/">
                <div id="logo"></div>
            </a>
            <div id="social-media">
                <a href="//facebook.com/" target="_blank">
                    <div class="social">
                        <img src="~/Content/img/facebook.png" alt="facebook" />
                    </div>
                </a>
                <a href="//twitter.com/" target="_blank">
                    <div class="social">
                        <img src="~/Content/img/twitter.png" alt="twitter" />
                    </div>
                </a>
                <a href="#" target="_blank">
                    <div class="social">
                        <img src="~/Content/img/googleplus.png" alt="google plus" />
                    </div>
                </a>
            </div>
        </header>
        <nav>
            <a href="/">
                <div class="nav-item">
                    <span>Ana Sayfa</span>
                </div>
            </a>
            <a href="Hakkında">
                <div class="nav-item">
                    <span>Hakkında</span>
                </div>
            </a>
            <a href="İletişim">
                <div class="nav-item" style="width: 192px; border-right: 0;">
                    <span>İletişim</span>
                </div>
            </a>
        </nav>
        <section id="content">
        @RenderBody()
    </section>
    <footer>
        <small>2020 &copy; Saklı Olan Birşey Yok.</small>
    </footer>
    </section>
</body>
</html>
