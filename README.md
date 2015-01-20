<h1>OgTagManager v1.0.1</h1>

OgTagManager is built on .net framework 4.5. It was designed to simplify the implementation of Og Tag for web applications. 
How to use it

* Install NuGet Package

* Example of usage
To add OgTags below:
<meta property="og:title" content="Title goes here" />
<meta property="og:url" content="Url goes here" />
<meta property="og:description" content="Description goes here" />
<meta property="og:site_name" content="Site name goes here" />

<meta property="og:Image" content="Image Url goes here" />
<meta property="og:image:secure_url" content="Image Secure Url goes here" />

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
