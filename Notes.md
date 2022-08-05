# Notes
About RenderableContentControl and its working.

- RenderIgnore
  - Presentation string is case sensitive. ShadowControl and shadowControl are **not** the same.
  - Control-Display presentation: ignores types that have either Control **or** Display ignore attribute. Basically, both presentation types are applied.

- Custom libraries
  - `Presentation="ShadowControl-Display-Manual"` - if custom view Manual is found it is used as the presentation view despite being at the end of the presentation string.
