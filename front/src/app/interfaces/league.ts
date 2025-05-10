export interface League {
    businessId: number;
    name: string;
    minExperience: number;
    maxExperience?: number;
    order: number;
    iconCssClass?: string;
}