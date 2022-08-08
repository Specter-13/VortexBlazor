# Notes

About RenderableContentControl and its working.

- RenderIgnore

  - Presentation string is case sensitive. `ShadowControl` and `shadowControl` are **not** the same.
  - `Control-Display` presentation: ignores types that have either `Control` **or** `Display` ignore attribute. Basically, both presentation types are applied.
  - `Presentation="ShadowControl-Display"` - `ShadowControl` is actually used as a view.

- Custom libraries
  - `Presentation="ShadowControl-Display-Manual"` - if custom view `Manual` is found it is used as the presentation view despite being at the end of the Presentation string.
  - `Presentation="Base-Manual"` - if `Base` is found it is used before `Manual`.
  - ```d
    TYPE VortexComponent :
    STRUCT
      {attribute clr [RenderIgnore("Manual")]}
      {attribute addProperty Name "<#Vortex bool#>"}
      vortex_bool: BOOL;
      {attribute wpf [Container(Layout.Wrap)]}
      vortex_wheel: Wheel;
    END_STRUCT
    END_TYPE
    ```
    `vortex_bool` is displayed even if Presentation mode is `Manual`.
  - `Presentation="Base"` and `Presentation=""` searches for VortexComponentView. If not found `Display` is used.
  - `@ViewModel.Component.vortex_wheel.AttributeName` only displays the name if in PLC the following is set **above** the vortex_wheel struct: `{attribute addProperty Name "<#Vortex wheel#>"}`
  - If the Presentation type is not found, nothing is rendered.
