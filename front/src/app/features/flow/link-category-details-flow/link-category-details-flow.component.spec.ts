import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LinkCategoryDetailsFlowComponent } from './link-category-details-flow.component';

describe('LinkCategoryDetailsFlowComponent', () => {
  let component: LinkCategoryDetailsFlowComponent;
  let fixture: ComponentFixture<LinkCategoryDetailsFlowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [LinkCategoryDetailsFlowComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(LinkCategoryDetailsFlowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
