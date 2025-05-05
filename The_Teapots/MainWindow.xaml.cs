using System.Text;
using System.Windows;
using SharpGL.SceneGraph.Primitives; // Para Teapot
using SharpGL.WPF;
using SharpGL;

namespace The_Teapots;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private float rotation = 0;
    private Teapot teapot = new Teapot();

    public MainWindow()
    {
        InitializeComponent();
    }
    private void OpenGLControl_OpenGLDraw(object sender, OpenGLRoutedEventArgs args)
    {
        OpenGL gl = args.OpenGL;

        gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
        gl.LoadIdentity();
        gl.Translate(0.0f, 0.0f, -5.0f);
        gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

        gl.Enable(OpenGL.GL_DEPTH_TEST);

        // Activar iluminación si hay al menos una luz activa
        if (chkAmbient.IsChecked == true || chkDiffuse.IsChecked == true || chkSpecular.IsChecked == true)
            gl.Enable(OpenGL.GL_LIGHTING);
        else
            gl.Disable(OpenGL.GL_LIGHTING);

        // Configurar la luz global ambiental
        if (chkGlobalAmbient.IsChecked == true)
        {
            float[] globalAmbient = new float[] { 0.3f, 0.3f, 0.3f, 1.0f };
            gl.LightModel(OpenGL.GL_LIGHT_MODEL_AMBIENT, globalAmbient);
        }

        // Posición de la luz
        if (chkLightPosition.IsChecked == true)
        {
            float[] lightPos = new float[] { 0.0f, 0.0f, 2.0f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_POSITION, lightPos);
        }

        // Componentes de la luz
        if (chkAmbient.IsChecked == true)
        {
            float[] ambientLight = new float[] { 0.3f, 0.3f, 0.3f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, ambientLight);
        }
        else
        {
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_AMBIENT, new float[] { 0, 0, 0, 1 });
        }

        if (chkDiffuse.IsChecked == true)
        {
            float[] diffuseLight = new float[] { 0.6f, 0.6f, 0.6f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, diffuseLight);
        }
        else
        {
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_DIFFUSE, new float[] { 0, 0, 0, 1 });
        }

        if (chkSpecular.IsChecked == true)
        {
            float[] specularLight = new float[] { 1.0f, 1.0f, 1.0f, 1.0f };
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, specularLight);
        }
        else
        {
            gl.Light(OpenGL.GL_LIGHT0, OpenGL.GL_SPECULAR, new float[] { 0, 0, 0, 1 });
        }

        gl.Enable(OpenGL.GL_LIGHT0);

        // Material de la tetera
        float[] mat_specular = { 1.0f, 1.0f, 1.0f, 1.0f };
        gl.Material(OpenGL.GL_FRONT, OpenGL.GL_SPECULAR, mat_specular);
        gl.Material(OpenGL.GL_FRONT, OpenGL.GL_SHININESS, 50.0f);

        gl.Color(1.0, 1.0, 1.0);

        // Dibujar la tetera
       // teapot.Draw(gl, 1.0f, RenderMode.Render);
        teapot.Draw(gl, 10, 1.0, OpenGL.GL_FILL);

        rotation += 0.5f;
    }
    private void OpenGLControl_OpenGLInitialized(object sender, OpenGLRoutedEventArgs args)
    {
        var gl = args.OpenGL;
        gl.ClearColor(0, 0, 0, 1);
    }
}
