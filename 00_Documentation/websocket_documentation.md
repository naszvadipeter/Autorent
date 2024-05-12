# WebSocket dokumentáció

Az `Admin` szerepnél a `felhasználók megtekintése` és `új felhasználó felvétele` funkciókhoz használtunk WebSocket kommunikációt.

Az admin belépése után a kliens felépít egy websocket kommunikációt a szerverrel, és listázza az összes felhasználót.

Ha bármely (admin) kliens egy új felhasználót vesz fel a rendszerben, akkor az a többi adminnál is megjelenik a felhasználók listában.
