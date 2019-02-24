//
//  UnityTapticPlugin.h
//  unity-taptic-plugin
//
//  Created by Koki Ibukuro on 12/6/16.
//  Modified by Ale Cámara in 2019.
//
//  Licensed under MIT License.
//  See LICENSE in root directory.
//

#ifndef UnityTapticPlugin_h
#define UnityTapticPlugin_h

#import <UIKit/UIKit.h>

@interface UnityTapticPlugin : NSObject
{}

+ (UnityTapticPlugin*) shared;
- (void) prepareNotification;
- (void) triggerNotification:(UINotificationFeedbackType) type;
- (void) prepareSelection;
- (void) triggerSelection;
- (void) prepareImpact:(UIImpactFeedbackStyle) style;
- (void) triggerImpact:(UIImpactFeedbackStyle) style;

+ (BOOL) isSupported;

@end

#endif /* UnityTapticPlugin_h */
