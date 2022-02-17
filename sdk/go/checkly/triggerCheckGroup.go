// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package checkly

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # TriggerCheckGroup
//
// `TriggerCheckGroup` allows users to manage Checkly trigger groups. Add a `TriggerCheckGroup` resource to your resource file.
//
// ## Example Usage
//
// Trigger group example
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-checkly/sdk/go/checkly"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := checkly.NewTriggerCheckGroup(ctx, "test-trigger-group", &checkly.TriggerCheckGroupArgs{
// 			GroupId: pulumi.Int(215),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("test-trigger-group-url", test_trigger_group.Url)
// 		return nil
// 	})
// }
// ```
type TriggerCheckGroup struct {
	pulumi.CustomResourceState

	// The id of the group that you want to attach the trigger to.
	GroupId pulumi.IntOutput    `pulumi:"groupId"`
	Token   pulumi.StringOutput `pulumi:"token"`
	Url     pulumi.StringOutput `pulumi:"url"`
}

// NewTriggerCheckGroup registers a new resource with the given unique name, arguments, and options.
func NewTriggerCheckGroup(ctx *pulumi.Context,
	name string, args *TriggerCheckGroupArgs, opts ...pulumi.ResourceOption) (*TriggerCheckGroup, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.GroupId == nil {
		return nil, errors.New("invalid value for required argument 'GroupId'")
	}
	var resource TriggerCheckGroup
	err := ctx.RegisterResource("checkly:index/triggerCheckGroup:TriggerCheckGroup", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTriggerCheckGroup gets an existing TriggerCheckGroup resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTriggerCheckGroup(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TriggerCheckGroupState, opts ...pulumi.ResourceOption) (*TriggerCheckGroup, error) {
	var resource TriggerCheckGroup
	err := ctx.ReadResource("checkly:index/triggerCheckGroup:TriggerCheckGroup", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering TriggerCheckGroup resources.
type triggerCheckGroupState struct {
	// The id of the group that you want to attach the trigger to.
	GroupId *int    `pulumi:"groupId"`
	Token   *string `pulumi:"token"`
	Url     *string `pulumi:"url"`
}

type TriggerCheckGroupState struct {
	// The id of the group that you want to attach the trigger to.
	GroupId pulumi.IntPtrInput
	Token   pulumi.StringPtrInput
	Url     pulumi.StringPtrInput
}

func (TriggerCheckGroupState) ElementType() reflect.Type {
	return reflect.TypeOf((*triggerCheckGroupState)(nil)).Elem()
}

type triggerCheckGroupArgs struct {
	// The id of the group that you want to attach the trigger to.
	GroupId int     `pulumi:"groupId"`
	Token   *string `pulumi:"token"`
	Url     *string `pulumi:"url"`
}

// The set of arguments for constructing a TriggerCheckGroup resource.
type TriggerCheckGroupArgs struct {
	// The id of the group that you want to attach the trigger to.
	GroupId pulumi.IntInput
	Token   pulumi.StringPtrInput
	Url     pulumi.StringPtrInput
}

func (TriggerCheckGroupArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*triggerCheckGroupArgs)(nil)).Elem()
}

type TriggerCheckGroupInput interface {
	pulumi.Input

	ToTriggerCheckGroupOutput() TriggerCheckGroupOutput
	ToTriggerCheckGroupOutputWithContext(ctx context.Context) TriggerCheckGroupOutput
}

func (*TriggerCheckGroup) ElementType() reflect.Type {
	return reflect.TypeOf((**TriggerCheckGroup)(nil)).Elem()
}

func (i *TriggerCheckGroup) ToTriggerCheckGroupOutput() TriggerCheckGroupOutput {
	return i.ToTriggerCheckGroupOutputWithContext(context.Background())
}

func (i *TriggerCheckGroup) ToTriggerCheckGroupOutputWithContext(ctx context.Context) TriggerCheckGroupOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TriggerCheckGroupOutput)
}

// TriggerCheckGroupArrayInput is an input type that accepts TriggerCheckGroupArray and TriggerCheckGroupArrayOutput values.
// You can construct a concrete instance of `TriggerCheckGroupArrayInput` via:
//
//          TriggerCheckGroupArray{ TriggerCheckGroupArgs{...} }
type TriggerCheckGroupArrayInput interface {
	pulumi.Input

	ToTriggerCheckGroupArrayOutput() TriggerCheckGroupArrayOutput
	ToTriggerCheckGroupArrayOutputWithContext(context.Context) TriggerCheckGroupArrayOutput
}

type TriggerCheckGroupArray []TriggerCheckGroupInput

func (TriggerCheckGroupArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TriggerCheckGroup)(nil)).Elem()
}

func (i TriggerCheckGroupArray) ToTriggerCheckGroupArrayOutput() TriggerCheckGroupArrayOutput {
	return i.ToTriggerCheckGroupArrayOutputWithContext(context.Background())
}

func (i TriggerCheckGroupArray) ToTriggerCheckGroupArrayOutputWithContext(ctx context.Context) TriggerCheckGroupArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TriggerCheckGroupArrayOutput)
}

// TriggerCheckGroupMapInput is an input type that accepts TriggerCheckGroupMap and TriggerCheckGroupMapOutput values.
// You can construct a concrete instance of `TriggerCheckGroupMapInput` via:
//
//          TriggerCheckGroupMap{ "key": TriggerCheckGroupArgs{...} }
type TriggerCheckGroupMapInput interface {
	pulumi.Input

	ToTriggerCheckGroupMapOutput() TriggerCheckGroupMapOutput
	ToTriggerCheckGroupMapOutputWithContext(context.Context) TriggerCheckGroupMapOutput
}

type TriggerCheckGroupMap map[string]TriggerCheckGroupInput

func (TriggerCheckGroupMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TriggerCheckGroup)(nil)).Elem()
}

func (i TriggerCheckGroupMap) ToTriggerCheckGroupMapOutput() TriggerCheckGroupMapOutput {
	return i.ToTriggerCheckGroupMapOutputWithContext(context.Background())
}

func (i TriggerCheckGroupMap) ToTriggerCheckGroupMapOutputWithContext(ctx context.Context) TriggerCheckGroupMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(TriggerCheckGroupMapOutput)
}

type TriggerCheckGroupOutput struct{ *pulumi.OutputState }

func (TriggerCheckGroupOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**TriggerCheckGroup)(nil)).Elem()
}

func (o TriggerCheckGroupOutput) ToTriggerCheckGroupOutput() TriggerCheckGroupOutput {
	return o
}

func (o TriggerCheckGroupOutput) ToTriggerCheckGroupOutputWithContext(ctx context.Context) TriggerCheckGroupOutput {
	return o
}

type TriggerCheckGroupArrayOutput struct{ *pulumi.OutputState }

func (TriggerCheckGroupArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*TriggerCheckGroup)(nil)).Elem()
}

func (o TriggerCheckGroupArrayOutput) ToTriggerCheckGroupArrayOutput() TriggerCheckGroupArrayOutput {
	return o
}

func (o TriggerCheckGroupArrayOutput) ToTriggerCheckGroupArrayOutputWithContext(ctx context.Context) TriggerCheckGroupArrayOutput {
	return o
}

func (o TriggerCheckGroupArrayOutput) Index(i pulumi.IntInput) TriggerCheckGroupOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *TriggerCheckGroup {
		return vs[0].([]*TriggerCheckGroup)[vs[1].(int)]
	}).(TriggerCheckGroupOutput)
}

type TriggerCheckGroupMapOutput struct{ *pulumi.OutputState }

func (TriggerCheckGroupMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*TriggerCheckGroup)(nil)).Elem()
}

func (o TriggerCheckGroupMapOutput) ToTriggerCheckGroupMapOutput() TriggerCheckGroupMapOutput {
	return o
}

func (o TriggerCheckGroupMapOutput) ToTriggerCheckGroupMapOutputWithContext(ctx context.Context) TriggerCheckGroupMapOutput {
	return o
}

func (o TriggerCheckGroupMapOutput) MapIndex(k pulumi.StringInput) TriggerCheckGroupOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *TriggerCheckGroup {
		return vs[0].(map[string]*TriggerCheckGroup)[vs[1].(string)]
	}).(TriggerCheckGroupOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*TriggerCheckGroupInput)(nil)).Elem(), &TriggerCheckGroup{})
	pulumi.RegisterInputType(reflect.TypeOf((*TriggerCheckGroupArrayInput)(nil)).Elem(), TriggerCheckGroupArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*TriggerCheckGroupMapInput)(nil)).Elem(), TriggerCheckGroupMap{})
	pulumi.RegisterOutputType(TriggerCheckGroupOutput{})
	pulumi.RegisterOutputType(TriggerCheckGroupArrayOutput{})
	pulumi.RegisterOutputType(TriggerCheckGroupMapOutput{})
}