<h1>OgTagManager v1.0.1</h1>

<p>OgTagManager is built on .net framework 4.5. It was designed to simplify the implementation of Og Tag for web applications.</p> 

<h2>How to use it</h2>

<strong><a href="https://www.nuget.org/packages/OgTagManager/" target="_blank" > Install NuGet Package </a></strong>

To add OgTag like below: <br />
meta property="og:title" content="Title goes here" 

Here is the sample code:

    var imageTagManager = new OgImageTagManager
                    (
                        new OgImageUrl { Content = "Image Url goes here" },
                        new OgImageSecureUrl { Content = "Image Secure Url goes here" }
                    );

            var basicTagManager = new OgBasicTagManager
                    (
                        new OgTitle { Content = "Title goes here" },
                        new OgUrl { Content = "Url goes here" },
                        new OgDescription { Content = "Description goes here" },
                        new OgSiteName { Content = "Site name goes here" },
                        imageTagManager
                    );

     var ogTags = basicTagManager.GetOgTagMeta();

	     foreach (var ogTag in ogTags)
            {
                Header.Controls.Add(ogTag);
     	    }
