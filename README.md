# Apklis Check Payment

Este package tiene como objetivo conocer el estado de pago de una app especifica para el usuario logeado en la app Apklis. Solo funciona para Android.

## Instalacion

Para instalar desde el UPM: https://docs.unity3d.com/Manual/upm-ui-giturl.html usando la url https://github.com/unitycuba/apklis-checkpayment.git

Tambien se puede añadir agregando la siguiente linea al archivo `[Project Root]/Packages/manifest.json` como se explica en https://docs.unity3d.com/Manual/upm-git.html

```
 "cu.unitycuba.apklischeckpayment": "https://github.com/unitycuba/apklis-checkpayment.git"
```


## Uso

Desde Unity puedes acceder a la clase `PaymentChecker` ubicada en `using Apklis.Payment;`. A continuacion un ejemplo de uso:

```
public bool CheckState()
    {
        var result = PaymentChecker.IsPurchased(input.text);

        if (result.username == null)
            messageText.SetText("Pliss autentificate en la app de Apklis para seguir jugando");
        else if (!result.paid)
            messageText.SetText("Esta es pago, por favor, adquierela a travez de Apklis");

        return result.paid;
    }
```
