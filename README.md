# Planetas VR

Este proyecto es una aplicación de realidad virtual desarrollada en Unity que permite explorar planetas en un entorno inmersivo. Utiliza **Vuforia Engine** para la detección y seguimiento de imágenes o marcadores.

## Requisitos

Para ejecutar y desarrollar este proyecto correctamente, necesitas:

- **Unity** (versión recomendada: 2021.3 o superior)
- **Vuforia Engine** (no incluido en el repositorio debido a restricciones de tamaño en GitHub)
- **Git LFS** (si deseas gestionar archivos grandes en el repositorio)

## Instalación de Vuforia

1. Descarga el paquete de Vuforia desde su [sitio oficial](https://developer.vuforia.com/downloads/sdk).
2. Copia el archivo `.tgz` de Vuforia en la carpeta `Packages/` del proyecto.
3. En Unity, ve a **Window > Package Manager** y selecciona **Add package from tarball...**
4. Busca y selecciona el archivo `com.ptc.vuforia.engine-11.0.4.tgz`.
5. Espera a que Unity lo instale y verifica que esté habilitado en **XR Plug-in Management**.

## Uso

1. Abre el proyecto en Unity.
2. Asegúrate de que tu cámara de AR esté configurada con Vuforia.
3. Ejecuta la escena principal para comenzar la exploración de los planetas en VR.

## Notas

- Debido a restricciones de tamaño, el paquete de Vuforia no está incluido en el repositorio. Debes descargarlo e instalarlo manualmente.
- Si tienes problemas con la configuración, revisa la [documentación oficial de Vuforia](https://library.vuforia.com/).

## Contribuciones

Si deseas contribuir al proyecto, por favor abre un issue o envía un pull request.

---

**Autor:** Joan Ferre

