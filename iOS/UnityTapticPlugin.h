//
//  UnityTapticPlugin.h
//  unity-taptic-plugin
//
//  Created by Koki Ibukuro on 12/6/16.
//  Copyright © 2016 asus4. All rights reserved.
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
