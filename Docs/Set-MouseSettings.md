---
external help file: MouseSettings.dll-Help.xml
Module Name: MouseSettings
online version:
schema: 2.0.0
---

# Set-MouseSettings

## SYNOPSIS
Sets various mouse settings.

## SYNTAX

```
Set-MouseSettings [-PrimaryButton <PrimaryButton>] [-ScrollTargetBehavior <ScrollTargetBehavior>]
 [-Speed <int>] [-AccelerationEnabled <bool>] [-AccelerationSpeed <int>] [-AccelerationThreshold1 <int>]
 [-AccelerationThreshold2 <int>] [-SonarEnabled <bool>] [-CursorHiddenWhenTyping <bool>]
 [-CursorSnapsToDefaultButton <bool>] [-MouseTrails <int>] [-HorizontalScrollCharCount <uint>]
 [-VerticalScrollLineCount <uint>] [-ClickLockEnabled <bool>] [-ClickLockDelay <uint>]
 [-HoverHeight <uint>] [-HoverWidth <uint>] [-HoverDelayMs <uint>] [-DoubleClickHeight <uint>]
 [-DoubleClickWidth <uint>] [-DoubleClickDelayMs <uint>] [-CursorSize <uint>] [<CommonParameters>]
```

## DESCRIPTION
Sets various mouse settings.

## EXAMPLES

### Example 1
```powershell
PS C:\> Set-MouseSettings -PrimaryButton Right -ScrollTargetBehavior Legacy -AccelerationEnabled $false -SonarEnabled $true
```

Swaps the primary button from Left to Right, disables scrolling inactive windows that the mouse hovers over, disables mouse acceleration and enables the mouse sonar feature.  
The mouse sonar feature highlights the mouse when you press the CTRL key.

## PARAMETERS

### -PrimaryButton
Swaps the Left and Right mouse button.

```yaml
Type: PrimaryButton
Parameter Sets: (All)
Aliases:
Accepted values: Left, Right

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ScrollTargetBehavior
Controls which windows scroll events are passed to. Valid values are:  
Legacy - The window with focus will get the scrolling events.  
Hybrid - If the mouse cursor is hovering over a modern app (WinRT/UWP) that app will receive the scrolling events, otherwise the app in focus will.  
Modern - The window that the mouse cursor is hovering over will receive the scrolling events.

```yaml
Type: ScrollTargetBehavior
Parameter Sets: (All)
Aliases:
Accepted values: Legacy, Hybrid, Modern

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Speed
Controls the mouse sensitivity. Can be set between 1-20 where 10 is the default.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccelerationEnabled
Enables or disables mouse acceleration by setting predefined values to the Acceleration parameters.  
This uses the same values that you get when managing mouse acceleration from the GUI.  
Note: It generally doesn't make sense to use this parameter along with the other Acceleration parameters.  
If you use this along with the other acceleration parameters the predefined values from this parameter will be set first, followed by the other acceleration parameters.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccelerationSpeed
Controls how much acceleration should be applied.  
Valid values are 0,1,2.  
0 - Disables mouse acceleration.  
1 - Doubles the mouse speed when AccelerationThreshold1 is reached.  
2 - Like 1 and also quadruples the mouse speed when AccelerationThreshold2 is reached.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccelerationThreshold1
Controls how many pixels the cursor needs to move in the polling interval before applying first mouse acceleration.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -AccelerationThreshold2
Controls how many pixels the cursor needs to move in the polling interval before applying second mouse acceleration.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SonarEnabled
Enables or disables the mouse sonar feature (Cursor highlight when CTRL is pressed).

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CursorHiddenWhenTyping
Controls whether or not the mouse cursor hides while typing.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CursorSnapsToDefaultButton
Controls whether or not the mouse cursor snaps to the default button when new dialog windows show up.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -MouseTrails
Controls if mouse trails are enabled, and how many there are.  
Valid values are 0-16.  
0 and 1 disable the feature, 2-16 adds the specified amount of cursor trails.

```yaml
Type: Int32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HorizontalScrollCharCount
Controls how many characters are scrolled when leaning the mousewheel left or right.  
Default is 3.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -VerticalScrollLineCount
Controls how many lines are scrolled when scrolling once with the mouse wheel.  
If the value is higher than the number of lines visible it will scroll an entire page (as if you pressed Page Up/Down).  
Default is 3.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClickLockEnabled
Enables or disables the clicklock feature.  
If enabled Windows will keep the mouse button held down after you release it if you hold it down for a short moment.  
Clicking with the mouse again will release the lock.

```yaml
Type: bool
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ClickLockDelay
Controls how long you need to hold down the mouse button to use the ClickLock feature.  
Default is 1200ms.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```


### -HoverHeight
Controls the height, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HoverWidth
Controls the width, in pixels, of the rectangle within which the mouse pointer has to stay for TrackMouseEvent to generate a WM_MOUSEHOVER message.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HoverDelayMs
Controls the time, in ms, that the mouse pointer has to stay in the hover rectangle for TrackMouseEvent to generate a WM_MOUSEHOVER message. 

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DoubleClickHeight
Controls the height of the double-click rectangle that checks whether or not the second click you made should count as a double click.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DoubleClickWidth
Controls the width of the double-click rectangle that checks whether or not the second click you made should count as a double click.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DoubleClickDelayMs
Controls how much time between clicks a double click takes.  
Default is 500ms

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -CursorSize
Controls how big the mouse cursor is.  
Default is 32.

```yaml
Type: UInt32
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### None

## OUTPUTS

### None
## NOTES

## RELATED LINKS
