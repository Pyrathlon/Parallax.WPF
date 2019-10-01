# Parallax.WPF
**Parallax Effect for WPF**

### Quickstart
```.xaml
<Window
       ...
        xmlns:Parallax="clr-namespace:Parallax.WPF.Controls;assembly=Parallax.WPF"
       ...>

    <Grid>
        <Parallax:MouseAwareParallaxContainer>
            <Parallax:MouseAwareParallaxContainer.Layers>
                <Parallax:ParallaxImageLayer ImageSource="/MyImage.jpg"/>
            </Parallax:MouseAwareParallaxContainer.Layers>
        </Parallax:MouseAwareParallaxContainer>
    </Grid>
```
Check the sample project for more info.
Will update the wiki aswell.

# Demo
https://i.imgur.com/Ikm9vrF.gif
